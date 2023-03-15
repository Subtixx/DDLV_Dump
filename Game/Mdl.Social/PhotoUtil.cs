using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.Rendering;

namespace Mdl.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000232")]
	public static class PhotoUtil
	{
		[Cpp2IlInjected.Token(Token = "0x4001317")]
		private static RenderTexture renderTexture;

		[Cpp2IlInjected.Token(Token = "0x4001318")]
		private static Action<Texture2D> RTcallback;

		[Cpp2IlInjected.Token(Token = "0x4001319")]
		public static RenderTextureFormat renderTextureFormat;

		[Cpp2IlInjected.Token(Token = "0x400131A")]
		public static TextureFormat textureFormat;

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0xF103E0", Offset = "0xF0EDE0", VA = "0x180F103E0")]
		public unsafe static Rect GetPhotoScreenRect(int width, int height)
		{
			int num = (((int*)width)->m_value = 0);
			int num2 = (((int*)width)->m_value = 0);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0xF10280", Offset = "0xF0EC80", VA = "0x180F10280")]
		public unsafe static Rect GetPhotoScreenRect(int screenWidth, int screenHeight, int width, int height, float canvasScale)
		{
			while (true)
			{
				int num = (((int*)screenWidth)->m_value = 0);
				int num2 = 0;
				if (num2 > num)
				{
				}
				if (num2 > num)
				{
					/*Error: Could not find block for branch target IL_0013*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0xF10260", Offset = "0xF0EC60", VA = "0x180F10260")]
		private static int GetPhotoMargin(int height)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0xF10EE0", Offset = "0xF0F8E0", VA = "0x180F10EE0")]
		public static Texture2D TakeSquarePicture(Camera camera)
		{
			//Discarded unreachable code: IL_0047
			//IL_0046: Expected O, but got I4
			int num = camera.pixelWidth;
			int num2 = 0;
			int num3 = camera.pixelHeight;
			int num4 = 0;
			int systemMemorySize = SystemInfo.systemMemorySize;
			if (num3 > 1080)
			{
				systemMemorySize = num;
				systemMemorySize -= num2;
				num = systemMemorySize;
				systemMemorySize = num3;
				systemMemorySize -= num2;
				num3 = systemMemorySize;
			}
			int num5 = 0;
			return TakePicture(camera, num, num3, (Rect)num5);
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0xF10C50", Offset = "0xF0F650", VA = "0x180F10C50")]
		public static Texture2D TakeSquarePicture(Camera camera, RectTransform rect, float canvasScale, int pixelMultiplier)
		{
			//Discarded unreachable code: IL_0051
			//IL_0050: Expected O, but got I4
			int pixelWidth = camera.pixelWidth;
			int pixelHeight = camera.pixelHeight;
			int num = 0;
			int width = camera.pixelWidth * pixelMultiplier;
			int height = camera.pixelHeight * pixelMultiplier;
			Vector2 sizeDelta = rect.sizeDelta;
			Vector2 sizeDelta2 = rect.sizeDelta;
			int num2 = 0;
			int num3 = 0;
			if (num3 > num2)
			{
			}
			if (num3 > num2)
			{
			}
			return TakePicture(camera, width, height, (Rect)num2);
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0xF108C0", Offset = "0xF0F2C0", VA = "0x180F108C0")]
		public unsafe static Texture2D TakePicture(Camera camera, int width, int height, Rect crop)
		{
			//Discarded unreachable code: IL_00a7
			//IL_009e: Expected O, but got I4
			//IL_00a4: Expected O, but got I4
			string text = string.Format("creating temporary rt {0}x{1}", "PictureRT", "PictureRT");
			int depthBuffer = 0;
			RenderTextureFormat format = renderTextureFormat;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer, format);
			temporary.name = "PictureRT";
			camera.targetTexture = temporary;
			camera.Render();
			float width2 = ((Rect*)crop)->width;
			float height2 = ((Rect*)crop)->height;
			string text2 = $"creating new texture {temporary}x{temporary}";
			float width3 = ((Rect*)crop)->width;
			float height3 = ((Rect*)crop)->height;
			TextureFormat textureFormat = PhotoUtil.textureFormat;
			Texture2D texture2D = default(Texture2D);
			texture2D.name = "PhotoUtilTex";
			texture2D.Apply();
			RenderTexture.ReleaseTemporary(temporary);
			int num = 0;
			camera.targetTexture = (RenderTexture)num;
			RenderTexture.SetActive((RenderTexture)0);
			return texture2D;
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0xF11150", Offset = "0xF0FB50", VA = "0x180F11150")]
		[IteratorStateMachine(typeof(_003CTakeSquareScreenCapture_003Ed__10))]
		public static IEnumerator TakeSquareScreenCapture(Camera camera, [Optional] Action<Texture2D> callback)
		{
			int _003C_003E1__state = default(int);
			_003CTakeSquareScreenCapture_003Ed__10 _003CTakeSquareScreenCapture_003Ed__ = new _003CTakeSquareScreenCapture_003Ed__10(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CTakeSquareScreenCapture_003Ed__.camera = camera;
			_003CTakeSquareScreenCapture_003Ed__.callback = callback;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0xF104E0", Offset = "0xF0EEE0", VA = "0x180F104E0")]
		private unsafe static void ReadbackCompleted(AsyncGPUReadbackRequest request)
		{
			//Discarded unreachable code: IL_00bb, IL_00cd
			//IL_0036: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			UnityEngine.Object.DestroyImmediate(renderTexture);
			if (!((AsyncGPUReadbackRequest*)request)->hasError)
			{
				int width = ((AsyncGPUReadbackRequest*)request)->width;
				int height = ((AsyncGPUReadbackRequest*)request)->height;
				string text = $"photo RT data: {width}x{height}";
				int width2 = ((AsyncGPUReadbackRequest*)request)->width;
				int height2 = ((AsyncGPUReadbackRequest*)request)->height;
				Texture2D texture2D = default(Texture2D);
				texture2D.name = "Screenshot";
				int width3 = ((AsyncGPUReadbackRequest*)request)->width;
				int height3 = ((AsyncGPUReadbackRequest*)request)->height;
				if (num2 < height3)
				{
					int height4 = ((AsyncGPUReadbackRequest*)request)->height;
					height4 -= num2;
					int destinationIndex = (height4 - 1) * height2;
					int sourceIndex = num2 * height2;
					byte[] sourceArray = default(byte[]);
					byte[] destinationArray = default(byte[]);
					Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, height2);
					num2++;
				}
				texture2D.Apply();
				((Action<T>)(object)RTcallback)?.Invoke((T)texture2D);
				throw new MissingMethodException();
			}
			Debug.LogError("Error Capturing Screenshot: With AsyncGPUReadbackRequest.");
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0xF110B0", Offset = "0xF0FAB0", VA = "0x180F110B0")]
		[IteratorStateMachine(typeof(_003CTakeSquareScreenCapture_003Ed__12))]
		public static IEnumerator TakeSquareScreenCapture(RectTransform rect, float canvasScale, int pixelMultiplier, [Optional] Action<Texture2D> callback)
		{
			int _003C_003E1__state = default(int);
			_003CTakeSquareScreenCapture_003Ed__12 _003CTakeSquareScreenCapture_003Ed__ = new _003CTakeSquareScreenCapture_003Ed__12(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CTakeSquareScreenCapture_003Ed__.rect = rect;
			_003CTakeSquareScreenCapture_003Ed__.callback = callback;
			_003CTakeSquareScreenCapture_003Ed__.canvasScale = canvasScale;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0xF0FB40", Offset = "0xF0E540", VA = "0x180F0FB40")]
		public unsafe static void AddWaterMark(Texture2D texture, Texture2D watermarkTexture, Vector2 pos)
		{
			//Discarded unreachable code: IL_0063
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected I4, but got Unknown
			//IL_003c: Expected native int or pointer, but got O
			int width = watermarkTexture.width;
			int height = watermarkTexture.height;
			int num = 0;
			Color[] pixels = watermarkTexture.GetPixels();
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int length = pixels.Length;
			if (num2 < length)
			{
				num += pixels;
				num3++;
				Color[] array = default(Color[]);
				float r = default(float);
				((Color*)(IntPtr)array)->r = r;
				num3 += num3;
				num3 += num3;
				num3 += num3;
				num3++;
			}
			texture.Apply();
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0xF100B0", Offset = "0xF0EAB0", VA = "0x180F100B0")]
		public static Texture2D CreateThumbnailFrom(Texture texture, int width = 64, int height = 64)
		{
			//Discarded unreachable code: IL_0052
			//IL_0044: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			RenderTexture renderTexture = new RenderTexture(width, height, 24);
			renderTexture.name = "PhotoUtil_ThumbnailRT";
			Graphics.Blit(texture, renderTexture);
			Texture2D texture2D = new Texture2D(width, height);
			texture2D.name = "PhotoUtil_ThumbnailTex";
			int num = 0;
			int destY = 0;
			int destX = 0;
			texture2D.ReadPixels((Rect)num, destX, destY);
			texture2D.Apply();
			RenderTexture.SetActive((RenderTexture)0);
			return texture2D;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0xF0FE00", Offset = "0xF0E800", VA = "0x180F0FE00")]
		public static Texture2D CreateAvatarThumbnail(int width = 64, int height = 64)
		{
			//Discarded unreachable code: IL_006c
			//IL_005e: Expected O, but got I4
			//IL_006a: Expected O, but got I4
			RenderTexture targetTexture = SystemRoot.Instance._avatar.appearance.PortraitCam.targetTexture;
			RenderTexture renderTexture = new RenderTexture(width, height, 24);
			renderTexture.name = "PhotoUtil_ThumbnailRT";
			Graphics.Blit(targetTexture, renderTexture);
			Texture2D texture2D = new Texture2D(width, height);
			texture2D.name = "PhotoUtil_ThumbnailTex";
			int num = 0;
			int destY = 0;
			int destX = 0;
			texture2D.ReadPixels((Rect)num, destX, destY);
			texture2D.Apply();
			RenderTexture.SetActive((RenderTexture)0);
			return texture2D;
		}
	}
}
