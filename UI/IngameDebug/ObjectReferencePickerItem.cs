using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class ObjectReferencePickerItem : RecycledListItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		[SerializeField]
		private Image background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		[SerializeField]
		private RawImage texturePreview;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private LayoutElement texturePreviewLayoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		[SerializeField]
		private Text referenceNameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private int m_skinVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private UISkin m_skin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private bool m_isSelected;

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public UnityEngine.Object Reference
		{
			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CReference_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CReference_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public UISkin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			get
			{
				return m_skin;
			}
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x12A3EE0", Offset = "0x12A28E0", VA = "0x1812A3EE0")]
			set
			{
				//Discarded unreachable code: IL_009d
				//IL_006a: Expected F4, but got I4
				//IL_0077: Expected F4, but got I4
				if (!(m_skin != value))
				{
					int version = m_skin.m_version;
					if (m_skinVersion == version)
					{
						return;
					}
				}
				m_skin = value;
				Transform transform = base.transform;
				UISkin skin = m_skin;
				int num = 0;
				if ((object)transform != null)
				{
					int lineHeight = m_skin.m_lineHeight;
					lineHeight += -7;
					int num2 = Mathf.Max(5, lineHeight);
					texturePreviewLayoutElement.SetWidth(lineHeight);
					texturePreviewLayoutElement.SetHeight(lineHeight);
					UISkin skin2 = m_skin;
					referenceNameText.SetSkinText(skin2);
					bool flag = (IsSelected = m_isSelected);
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0xFB01D0", Offset = "0xFAEBD0", VA = "0x180FB01D0")]
			get
			{
				return m_isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x12A3DF0", Offset = "0x12A27F0", VA = "0x1812A3DF0")]
			set
			{
				//Discarded unreachable code: IL_0063
				m_isSelected = value;
				if (!value)
				{
					Image image = background;
					UISkin skin = m_skin;
					Text text = referenceNameText;
				}
				UISkin skin2 = m_skin;
				Image image2 = background;
				Color color = (image2.color = skin2.m_selectedItemBackgroundColor);
				UISkin skin3 = m_skin;
				Text text2 = referenceNameText;
				Color color2 = (text2.color = skin3.m_selectedItemTextColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x12A3BC0", Offset = "0x12A25C0", VA = "0x1812A3BC0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_002f
			LayoutElement layoutElement = (texturePreviewLayoutElement = texturePreview.GetComponent<LayoutElement>());
			PointerEventListener component = GetComponent<PointerEventListener>();
			PointerEventListener.PointerEvent value = delegate
			{
				OnClick();
			};
			component.PointerClick += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x12A3CA0", Offset = "0x12A26A0", VA = "0x1812A3CA0")]
		public void SetContent(UnityEngine.Object reference)
		{
			//Discarded unreachable code: IL_0070
			//IL_0017: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			Reference = reference;
			Text text = referenceNameText;
			int num = 0;
			string text2 = (text.text = reference.GetNameWithType((Type)num));
			Texture texture = reference.GetTexture();
			int num2 = 0;
			bool flag = texture != (UnityEngine.Object)num2;
			RawImage rawImage = texturePreview;
			if (!flag)
			{
				GameObject gameObject = rawImage.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			else
			{
				rawImage.gameObject.SetActive(value: true);
				texturePreview.texture = texture;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public ObjectReferencePickerItem()
		{
			((SkinnedMeshRenderer)(object)this)._002Ector();
		}
	}
}
