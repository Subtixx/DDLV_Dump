using System;
using System.IO;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000004")]
[RequireComponent(typeof(Camera))]
internal class TakePicture : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public string directory = "Temp/Pictures";

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string AbsoluteDirectory
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1EA2240", Offset = "0x1EA0C40", VA = "0x181EA2240")]
		get
		{
			int num = 0;
			string dataPath = Application.dataPath;
			string path = directory;
			return Path.Combine(dataPath, path);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1EA1E30", Offset = "0x1EA0830", VA = "0x181EA1E30")]
	private void Start()
	{
		//Discarded unreachable code: IL_0129
		//IL_009b: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		Camera component = GetComponent<Camera>();
		int pixelWidth = component.pixelWidth;
		int pixelHeight = component.pixelHeight;
		int mipChain = 0;
		int format = 0;
		int depthBuffer = 0;
		RenderTexture temporary = RenderTexture.GetTemporary(pixelWidth, pixelHeight, depthBuffer, (RenderTextureFormat)format);
		temporary.name = "PictureRT";
		component.targetTexture = temporary;
		component.Render();
		RenderTexture.SetActive(temporary);
		int width = temporary.width;
		pixelWidth = temporary.height;
		Texture2D texture2D = new Texture2D(width, pixelWidth, TextureFormat.RGBA32, (byte)mipChain != 0);
		texture2D.name = "PictureTex";
		pixelWidth = temporary.width;
		int height = temporary.height;
		int num = 0;
		int destY = 0;
		int destX = 0;
		texture2D.ReadPixels((Rect)num, destX, destY);
		RenderTexture.ReleaseTemporary(temporary);
		int num2 = 0;
		component.targetTexture = (RenderTexture)num2;
		RenderTexture.SetActive((RenderTexture)0);
		byte[] bytes = texture2D.EncodeToPNG();
		int num3 = 0;
		string dataPath = Application.dataPath;
		string path = directory;
		DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.Combine(dataPath, path));
		int num4 = 0;
		string dataPath2 = Application.dataPath;
		string path2 = directory;
		string path3 = Path.Combine(dataPath2, path2);
		int num5 = 0;
		DateTime utcNow = DateTime.UtcNow;
		string text = default(string);
		string path4 = "image_" + text + ".png";
		File.WriteAllBytes(Path.Combine(path3, path4), bytes);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1EA21F0", Offset = "0x1EA0BF0", VA = "0x181EA21F0")]
	public TakePicture()
	{
	}
}
