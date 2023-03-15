using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	public class ByteImageLoader : HttpImageLoader
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0xA6CF60", Offset = "0xA6B960", VA = "0x180A6CF60")]
		public void LoadImage(byte[] buffer, [Optional] Action callBack)
		{
			//Discarded unreachable code: IL_008f
			//IL_0025: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			Image mcImage = _mcImage;
			Color color2 = (mcImage.color = startColor);
			Image mcImage2 = _mcImage;
			int num = 0;
			mcImage2.sprite = (Sprite)num;
			Sprite defauldImage = _defauldImage;
			int num2 = 0;
			if (defauldImage != (UnityEngine.Object)num2 && (buffer == null || buffer.Length == 0))
			{
				Image mcImage3 = _mcImage;
				Sprite sprite = (mcImage3.sprite = _defauldImage);
				Image mcImage4 = _mcImage;
				Color color4 = (mcImage4.color = loadedColor);
				callBack?.Invoke();
			}
			else
			{
				GetImageRequest(buffer, callBack);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0xA6CCE0", Offset = "0xA6B6E0", VA = "0x180A6CCE0")]
		private void GetImageRequest(byte[] buffer, [Optional] Action callBack)
		{
			//Discarded unreachable code: IL_00c7
			//IL_0073: Expected O, but got I4
			_throbber?.Show();
			if (buffer != null && buffer.Length != 0)
			{
				Texture2D texture2D = new Texture2D(2, 2);
				texture2D.name = "ImageFromByteBuffer";
				bool flag = texture2D.LoadImage(buffer);
				if ((bool)texture2D)
				{
					int width = texture2D.width;
					int height = texture2D.height;
					int num = 0;
					int num2 = 0;
				}
				Image mcImage = _mcImage;
			}
			Sprite defauldImage = _defauldImage;
			int num3 = 0;
			if (defauldImage != (UnityEngine.Object)num3)
			{
				Image mcImage2 = _mcImage;
				Sprite sprite = (mcImage2.sprite = _defauldImage);
				Image mcImage3 = _mcImage;
				Color color2 = (mcImage3.color = loadedColor);
				callBack?.Invoke();
			}
			_throbber?.Hide();
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC50", Offset = "0xA6B650", VA = "0x180A6CC50")]
		private static Texture2D CreateTextureFromBytes(byte[] buffer)
		{
			//Discarded unreachable code: IL_001d
			Texture2D texture2D = new Texture2D(2, 2);
			texture2D.name = "ImageFromByteBuffer";
			bool flag = texture2D.LoadImage(buffer);
			return texture2D;
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0xA6CAD0", Offset = "0xA6B4D0", VA = "0x180A6CAD0")]
		private static Sprite CreateSpriteFromBytes(byte[] buffer)
		{
			Texture2D texture2D = new Texture2D(2, 2);
			texture2D.name = "ImageFromByteBuffer";
			bool flag = texture2D.LoadImage(buffer);
			if ((bool)texture2D)
			{
				int width = texture2D.width;
				int height = texture2D.height;
				int num = 0;
				Sprite result = default(Sprite);
				return result;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0xA6D0A0", Offset = "0xA6BAA0", VA = "0x180A6D0A0")]
		public ByteImageLoader()
		{
		}
	}
}
