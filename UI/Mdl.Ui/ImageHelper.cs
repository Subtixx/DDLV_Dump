using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000850")]
	public class ImageHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40030D5")]
		[SerializeField]
		private Color _startColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40030D6")]
		[SerializeField]
		private Color _loadedColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40030D7")]
		public Image Image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40030D8")]
		public RawImage RawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40030D9")]
		[SerializeField]
		private Sprite _placeHolderSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40030DA")]
		[SerializeField]
		private AsyncImage AsyncImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40030DB")]
		[SerializeField]
		public AsyncAtlassedIcon AsyncAtlassedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40030DC")]
		public SpriteAtlasImage SpriteAtlasImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40030DD")]
		public AssetReferenceTexture AssetReference;

		[Cpp2IlInjected.Token(Token = "0x17000770")]
		public IItemData ItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600349D")]
			[Cpp2IlInjected.Address(RVA = "0x63F8B0", Offset = "0x63E2B0", VA = "0x18063F8B0")]
			[CompilerGenerated]
			get
			{
				return _003CItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600349E")]
			[Cpp2IlInjected.Address(RVA = "0x63FD10", Offset = "0x63E710", VA = "0x18063FD10")]
			[CompilerGenerated]
			set
			{
				_003CItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000771")]
		public string SpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x600349F")]
			[Cpp2IlInjected.Address(RVA = "0x63F640", Offset = "0x63E040", VA = "0x18063F640")]
			[CompilerGenerated]
			get
			{
				return _003CSpriteName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60034A0")]
			[Cpp2IlInjected.Address(RVA = "0x63FA60", Offset = "0x63E460", VA = "0x18063FA60")]
			[CompilerGenerated]
			set
			{
				_003CSpriteName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000772")]
		public string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60034A1")]
			[Cpp2IlInjected.Address(RVA = "0x70CB80", Offset = "0x70B580", VA = "0x18070CB80")]
			[CompilerGenerated]
			get
			{
				return _003CIconAddress_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60034A2")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4A0", Offset = "0x7D9EA0", VA = "0x1807DB4A0")]
			[CompilerGenerated]
			set
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034A3")]
		[Cpp2IlInjected.Address(RVA = "0x1310590", Offset = "0x130EF90", VA = "0x181310590")]
		public void LoadAsyncImage()
		{
			//Discarded unreachable code: IL_00a3
			//IL_0010: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			//IL_0067: Expected O, but got I4
			SpriteAtlasImage spriteAtlasImage = SpriteAtlasImage;
			int num = 0;
			if (spriteAtlasImage != (UnityEngine.Object)num)
			{
				SpriteAtlasImage spriteAtlasImage2 = SpriteAtlasImage;
				int num2 = ((spriteAtlasImage2.enabled = false) ? 1 : 0);
			}
			AsyncImage asyncImage = AsyncImage;
			int num3 = 0;
			bool flag2 = asyncImage != (UnityEngine.Object)num3;
			if (!flag2)
			{
				return;
			}
			if ((long)IconAddress == 0)
			{
				if (ItemData != null && flag2)
				{
					IItemData itemData = ItemData;
					IconAddress = (string)flag2;
				}
				if ((long)IconAddress == 0)
				{
					return;
				}
			}
			int num4 = 0;
			if (Application.isPlaying)
			{
				AsyncImage.enabled = true;
				AsyncImage asyncImage2 = AsyncImage;
				string spriteKey = IconAddress;
				asyncImage2.SetSpriteKey(spriteKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034A4")]
		[Cpp2IlInjected.Address(RVA = "0x1311C70", Offset = "0x1310670", VA = "0x181311C70")]
		public void SetSpriteAtlasImage()
		{
			//Discarded unreachable code: IL_007f
			//IL_0010: Expected O, but got I4
			//IL_0037: Expected O, but got I4
			AsyncImage asyncImage = AsyncImage;
			int num = 0;
			if (asyncImage != (UnityEngine.Object)num)
			{
				AsyncImage asyncImage2 = AsyncImage;
				int num2 = ((asyncImage2.enabled = false) ? 1 : 0);
			}
			SpriteAtlasImage spriteAtlasImage = SpriteAtlasImage;
			int num3 = 0;
			if (spriteAtlasImage != (UnityEngine.Object)num3 && (long)SpriteName != 0)
			{
				SpriteAtlasImage.enabled = true;
				SpriteAtlasImage spriteAtlasImage2 = SpriteAtlasImage;
				string text2 = (spriteAtlasImage2.ImageAddress = SpriteName);
				Image image = SpriteAtlasImage.Image;
				Color white = Color.white;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034A5")]
		[Cpp2IlInjected.Address(RVA = "0x1310420", Offset = "0x130EE20", VA = "0x181310420")]
		public void LoadAsyncAtlassedIcon()
		{
			//Discarded unreachable code: IL_00b8
			//IL_0010: Expected O, but got I4
			//IL_003b: Expected O, but got I4
			do
			{
				AsyncAtlassedIcon asyncAtlassedIcon = AsyncAtlassedIcon;
				int num = 0;
				bool flag = asyncAtlassedIcon != (UnityEngine.Object)num;
				if (!flag)
				{
					return;
				}
				if ((long)IconAddress == 0)
				{
					if (ItemData != null && flag)
					{
						IItemData itemData = ItemData;
						IconAddress = (string)flag;
					}
					if ((long)IconAddress == 0)
					{
						if ((long)AssetReference != 0)
						{
							int num2 = 0;
							if (Application.isPlaying)
							{
								AsyncAtlassedIcon.enabled = true;
								AsyncAtlassedIcon asyncAtlassedIcon2 = AsyncAtlassedIcon;
								AssetReferenceTexture assetReference = AssetReference;
								asyncAtlassedIcon2.SetIconRef(assetReference);
							}
						}
						return;
					}
				}
				int num3 = 0;
			}
			while (!Application.isPlaying);
			AsyncAtlassedIcon.enabled = true;
			AsyncAtlassedIcon asyncAtlassedIcon3 = AsyncAtlassedIcon;
			string icon = IconAddress;
			bool flag2 = asyncAtlassedIcon3.SetIcon(icon);
		}

		[Cpp2IlInjected.Token(Token = "0x60034A6")]
		[Cpp2IlInjected.Address(RVA = "0x1310300", Offset = "0x130ED00", VA = "0x181310300")]
		[AsyncStateMachine(typeof(_003CLoadAddressableImage_003Ed__24))]
		private Task LoadAddressableImage()
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60034A7")]
		[Cpp2IlInjected.Address(RVA = "0x13116F0", Offset = "0x13100F0", VA = "0x1813116F0")]
		public void SetColorRGB(int rgb)
		{
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60034A8")]
		[Cpp2IlInjected.Address(RVA = "0x1311680", Offset = "0x1310080", VA = "0x181311680")]
		public void SetColorRGBA(int rgba)
		{
			int num = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60034A9")]
		[Cpp2IlInjected.Address(RVA = "0x1311150", Offset = "0x130FB50", VA = "0x181311150")]
		public void SetAlpha(float a)
		{
			//IL_0010: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0061: Expected O, but got I4
			//IL_009e: Expected O, but got I4
			//IL_00e6: Expected O, but got I4
			SpriteAtlasImage spriteAtlasImage = SpriteAtlasImage;
			int num = 0;
			if (!(spriteAtlasImage != (UnityEngine.Object)num))
			{
				AsyncImage asyncImage = AsyncImage;
				int num2 = 0;
				if (!(asyncImage != (UnityEngine.Object)num2))
				{
					AsyncAtlassedIcon asyncAtlassedIcon = AsyncAtlassedIcon;
					int num3 = 0;
					if (!(asyncAtlassedIcon != (UnityEngine.Object)num3))
					{
						return;
					}
					AsyncAtlassedIcon asyncAtlassedIcon2 = AsyncAtlassedIcon;
					if (asyncAtlassedIcon2.IsLoading)
					{
						int num4 = 0;
						asyncAtlassedIcon2.loadedColor = (Color)num4;
						return;
					}
					RawImage rawImage = asyncAtlassedIcon.RawImage;
					RawImage rawImage2 = AsyncAtlassedIcon.RawImage;
					RawImage rawImage3 = AsyncAtlassedIcon.RawImage;
					AsyncAtlassedIcon asyncAtlassedIcon3 = AsyncAtlassedIcon;
					int num5 = 0;
					asyncAtlassedIcon3.RawImage.color = (Color)num5;
					AsyncAtlassedIcon asyncAtlassedIcon4 = AsyncAtlassedIcon;
				}
				Image image = AsyncImage.Image;
				Image image2 = AsyncImage.Image;
				Image image3 = AsyncImage.Image;
				AsyncImage asyncImage2 = AsyncImage;
				int num6 = 0;
				asyncImage2.Image.color = (Color)num6;
				AsyncImage asyncImage3 = AsyncImage;
			}
			Image image4 = SpriteAtlasImage.Image;
			Image image5 = SpriteAtlasImage.Image;
			Image image6 = SpriteAtlasImage.Image;
			Image image7 = SpriteAtlasImage.Image;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034AA")]
		[Cpp2IlInjected.Address(RVA = "0x1311620", Offset = "0x1310020", VA = "0x181311620")]
		public unsafe void SetColorHTML(string htmlColor)
		{
			//IL_0013: Expected O, but got I4
			int num = 0;
			if (!ColorUtility.TryParseHtmlString(htmlColor, out *(Color*)num))
			{
			}
			SetColor((Color)num);
		}

		[Cpp2IlInjected.Token(Token = "0x60034AB")]
		[Cpp2IlInjected.Address(RVA = "0x1311760", Offset = "0x1310160", VA = "0x181311760")]
		public void SetColor(Color color)
		{
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			SpriteAtlasImage spriteAtlasImage = SpriteAtlasImage;
			int num = 0;
			if (!(spriteAtlasImage != (UnityEngine.Object)num))
			{
				AsyncImage asyncImage = AsyncImage;
				int num2 = 0;
				if (!(asyncImage != (UnityEngine.Object)num2))
				{
					AsyncAtlassedIcon asyncAtlassedIcon = AsyncAtlassedIcon;
					int num3 = 0;
					if (asyncAtlassedIcon != (UnityEngine.Object)num3)
					{
						AsyncAtlassedIcon asyncAtlassedIcon2 = AsyncAtlassedIcon;
						AsyncAtlassedIcon asyncAtlassedIcon3 = AsyncAtlassedIcon;
						if (!asyncAtlassedIcon3.IsLoading)
						{
							RawImage rawImage = asyncAtlassedIcon3.RawImage;
						}
					}
					return;
				}
				Image image = AsyncImage.Image;
				AsyncImage asyncImage2 = AsyncImage;
			}
			Image image2 = SpriteAtlasImage.Image;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034AC")]
		[Cpp2IlInjected.Address(RVA = "0x1310900", Offset = "0x130F300", VA = "0x181310900")]
		public unsafe void LoadSprite(GameObject uriProvider)
		{
			//Discarded unreachable code: IL_0083
			//IL_000b: Expected O, but got I4
			//IL_003f: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			//IL_007c: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (uriProvider == (UnityEngine.Object)num2 || !Enum.TryParse<SpriteType>(base.gameObject.name, out *(SpriteType*)num))
			{
				return;
			}
			if (uriProvider.TryGetComponent<IHasSpriteURI>(out *(IHasSpriteURI*)num))
			{
				SpriteAtlasImage spriteAtlasImage = SpriteAtlasImage;
				int num3 = 0;
				bool flag = spriteAtlasImage != (UnityEngine.Object)num3;
				if (!flag)
				{
					AsyncImage asyncImage = AsyncImage;
					int num4 = 0;
					if (!(asyncImage != (UnityEngine.Object)num4))
					{
						AsyncAtlassedIcon asyncAtlassedIcon = AsyncAtlassedIcon;
						int num5 = 0;
						if (!(asyncAtlassedIcon != (UnityEngine.Object)num5))
						{
							goto IL_007c;
						}
					}
				}
				SpriteName = (string)flag;
			}
			goto IL_007c;
			IL_007c:
			Load();
		}

		[Cpp2IlInjected.Token(Token = "0x60034AD")]
		[Cpp2IlInjected.Address(RVA = "0x13106F0", Offset = "0x130F0F0", VA = "0x1813106F0")]
		public unsafe void LoadAsyncSprite(GameObject referenceProvider)
		{
			//Discarded unreachable code: IL_005f
			//IL_000b: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (referenceProvider == (UnityEngine.Object)num2)
			{
				return;
			}
			AsyncAtlassedIcon asyncAtlassedIcon = AsyncAtlassedIcon;
			int num3 = 0;
			if (asyncAtlassedIcon == (UnityEngine.Object)num3 || !Enum.TryParse<SpriteType>(base.gameObject.name, out *(SpriteType*)num))
			{
				return;
			}
			bool flag = referenceProvider.TryGetComponent<IHasTextureReference>(out *(IHasTextureReference*)num);
			if (flag)
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					num++;
				}
				AssetReference = (AssetReferenceTexture)flag;
			}
			Load();
		}

		[Cpp2IlInjected.Token(Token = "0x60034AE")]
		[Cpp2IlInjected.Address(RVA = "0x13118E0", Offset = "0x13102E0", VA = "0x1813118E0")]
		public unsafe void SetColor(GameObject colorProvider)
		{
			//Discarded unreachable code: IL_002b
			//IL_000b: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (colorProvider != (UnityEngine.Object)num2)
			{
				uint num3 = default(uint);
				if (colorProvider.TryGetComponent<IHasUIntValue>(out *(IHasUIntValue*)num) && num < (int)num3)
				{
					num += num;
					num++;
				}
				Load();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034AF")]
		[Cpp2IlInjected.Address(RVA = "0x1311A90", Offset = "0x1310490", VA = "0x181311A90")]
		public unsafe void SetFillAmount(GameObject valueProvider)
		{
			//Discarded unreachable code: IL_005f
			//IL_000b: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (valueProvider == (UnityEngine.Object)num2)
			{
				return;
			}
			Image image = Image;
			int num3 = 0;
			if (!(image == (UnityEngine.Object)num3) && Enum.TryParse<FloatValueType>(base.gameObject.name, out *(FloatValueType*)num) && valueProvider.TryGetComponent<IHasFloatValue>(out *(IHasFloatValue*)num))
			{
				Image image2 = Image;
				int num4 = 0;
				if (image2 != (UnityEngine.Object)num4)
				{
					Image image3 = Image;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034B0")]
		[Cpp2IlInjected.Address(RVA = "0x1311DA0", Offset = "0x13107A0", VA = "0x181311DA0")]
		public unsafe void SetWidth(GameObject valueProvider)
		{
			//Discarded unreachable code: IL_005f
			//IL_000b: Expected O, but got I4
			//IL_001e: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			if (!(valueProvider == (UnityEngine.Object)num2))
			{
				Image image = Image;
				int num3 = 0;
				if (!(image == (UnityEngine.Object)num3) && Enum.TryParse<FloatValueType>(base.gameObject.name, out *(FloatValueType*)num) && valueProvider.TryGetComponent<IHasFloatValue>(out *(IHasFloatValue*)num))
				{
					RectTransform rectTransform = Image.rectTransform;
					Vector2 sizeDelta = Image.rectTransform.sizeDelta;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034B1")]
		[Cpp2IlInjected.Address(RVA = "0x1310B40", Offset = "0x130F540", VA = "0x181310B40")]
		public void Load()
		{
			//IL_0010: Expected O, but got I4
			//IL_0026: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			//IL_011a: Expected O, but got I4
			//IL_014a: Expected O, but got I4
			//IL_01dc: Expected O, but got I4
			//IL_0207: Expected O, but got I4
			//IL_025d: Expected O, but got I4
			Task asyncTask = default(Task);
			SpriteAtlasImage spriteAtlasImage4;
			int num14;
			do
			{
				IL_0000:
				SpriteAtlasImage spriteAtlasImage = SpriteAtlasImage;
				int num = 0;
				if (!(spriteAtlasImage != (UnityEngine.Object)num))
				{
					AsyncAtlassedIcon asyncAtlassedIcon = AsyncAtlassedIcon;
					int num2 = 0;
					if (!(asyncAtlassedIcon != (UnityEngine.Object)num2))
					{
						AsyncImage asyncImage = AsyncImage;
						int num3 = 0;
						if (!(asyncImage != (UnityEngine.Object)num3))
						{
							if ((long)AssetReference != 0)
							{
								int num4 = 0;
								asyncTask.FireAndForgetTask();
							}
							return;
						}
						SpriteAtlasImage spriteAtlasImage2 = SpriteAtlasImage;
						int num5 = 0;
						if (spriteAtlasImage2 != (UnityEngine.Object)num5)
						{
							SpriteAtlasImage spriteAtlasImage3 = SpriteAtlasImage;
							int num6 = ((spriteAtlasImage3.enabled = false) ? 1 : 0);
						}
						AsyncImage asyncImage2 = AsyncImage;
						int num7 = 0;
						bool flag2 = asyncImage2 != (UnityEngine.Object)num7;
						while (!flag2)
						{
						}
						if ((long)IconAddress == 0)
						{
							if (ItemData != null && flag2)
							{
								IItemData itemData = ItemData;
								IconAddress = (string)flag2;
							}
							while ((long)IconAddress == 0)
							{
							}
						}
						int num8 = 0;
						if (!Application.isPlaying)
						{
							goto IL_0000;
						}
						AsyncImage.enabled = true;
						AsyncImage asyncImage3 = AsyncImage;
						string spriteKey = IconAddress;
						asyncImage3.SetSpriteKey(spriteKey);
					}
					AsyncAtlassedIcon asyncAtlassedIcon2 = AsyncAtlassedIcon;
					int num9 = 0;
					bool flag3 = asyncAtlassedIcon2 != (UnityEngine.Object)num9;
					while (!flag3)
					{
					}
					if ((long)IconAddress == 0)
					{
						if (ItemData != null && flag3)
						{
							IItemData itemData2 = ItemData;
							IconAddress = (string)flag3;
						}
						if ((long)IconAddress == 0)
						{
							while ((long)AssetReference == 0)
							{
							}
							int num10 = 0;
							if (!Application.isPlaying)
							{
								goto IL_0000;
							}
							AsyncAtlassedIcon.enabled = true;
							AsyncAtlassedIcon asyncAtlassedIcon3 = AsyncAtlassedIcon;
							AssetReferenceTexture assetReference = AssetReference;
							asyncAtlassedIcon3.SetIconRef(assetReference);
						}
					}
					int num11 = 0;
					if (!Application.isPlaying)
					{
						goto IL_0000;
					}
					AsyncAtlassedIcon.enabled = true;
					AsyncAtlassedIcon asyncAtlassedIcon4 = AsyncAtlassedIcon;
					string icon = IconAddress;
					bool flag4 = asyncAtlassedIcon4.SetIcon(icon);
				}
				AsyncImage asyncImage4 = AsyncImage;
				int num12 = 0;
				if (asyncImage4 != (UnityEngine.Object)num12)
				{
					AsyncImage asyncImage5 = AsyncImage;
					int num13 = ((asyncImage5.enabled = false) ? 1 : 0);
				}
				spriteAtlasImage4 = SpriteAtlasImage;
				num14 = 0;
			}
			while (!(spriteAtlasImage4 != (UnityEngine.Object)num14));
			while ((long)SpriteName == 0)
			{
			}
			SpriteAtlasImage.enabled = true;
			SpriteAtlasImage spriteAtlasImage5 = SpriteAtlasImage;
			string text2 = (spriteAtlasImage5.ImageAddress = SpriteName);
			Image image = SpriteAtlasImage.Image;
			int num15 = 0;
			Color white = Color.white;
			image.color = (Color)num15;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034B2")]
		[Cpp2IlInjected.Address(RVA = "0x1311FB0", Offset = "0x13109B0", VA = "0x181311FB0")]
		public void Unload()
		{
			//Discarded unreachable code: IL_0105
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_005e: Expected O, but got I4
			//IL_007a: Expected O, but got I4
			//IL_00c0: Expected O, but got I4
			//IL_00d7: Expected O, but got I4
			Image image = Image;
			int num = 0;
			if (!(image != (UnityEngine.Object)num))
			{
				RawImage rawImage = RawImage;
				int num2 = 0;
				if (!(rawImage != (UnityEngine.Object)num2))
				{
					goto IL_00ac;
				}
				RawImage rawImage2 = RawImage;
				Color color = (rawImage2.color = _startColor);
				RawImage rawImage3 = RawImage;
				Sprite placeHolderSprite = _placeHolderSprite;
				int num3 = 0;
				if (placeHolderSprite != (UnityEngine.Object)num3)
				{
					Texture2D texture = _placeHolderSprite.texture;
				}
				int num4 = 0;
				rawImage3.texture = (Texture)num4;
			}
			Image image2 = Image;
			Color color2 = (image2.color = _startColor);
			Image image3 = Image;
			Sprite sprite = (image3.sprite = _placeHolderSprite);
			goto IL_00ac;
			IL_00ac:
			AsyncAtlassedIcon asyncAtlassedIcon = AsyncAtlassedIcon;
			int num5 = 0;
			if (!(asyncAtlassedIcon != (UnityEngine.Object)num5))
			{
				AsyncImage asyncImage = AsyncImage;
				int num6 = 0;
				if (!(asyncImage != (UnityEngine.Object)num6))
				{
					goto IL_00f0;
				}
				AsyncImage.Release();
			}
			AsyncAtlassedIcon.Release();
			goto IL_00f0;
			IL_00f0:
			AssetReference?.ReleaseAsset();
		}

		[Cpp2IlInjected.Token(Token = "0x60034B3")]
		[Cpp2IlInjected.Address(RVA = "0x1311130", Offset = "0x130FB30", VA = "0x181311130")]
		public void RemoveAssetReference()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60034B4")]
		[Cpp2IlInjected.Address(RVA = "0x13121E0", Offset = "0x1310BE0", VA = "0x1813121E0")]
		public ImageHelper()
		{
			Color white = Color.white;
			base._002Ector();
		}
	}
}
