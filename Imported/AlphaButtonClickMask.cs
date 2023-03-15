using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected Image _image;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2F06380", Offset = "0x2F04D80", VA = "0x182F06380")]
	public void Start()
	{
		//Discarded unreachable code: IL_0041, IL_0042, IL_0048
		//IL_0028: Expected O, but got I4
		Image image = (_image = GetComponent<Image>());
		Texture2D texture = _image.m_Sprite.texture;
		int num = 0;
		if (texture != (UnityEngine.Object)num)
		{
			Debug.LogError(texture.GetPixels32());
		}
		Debug.LogError("This script need an Image with a readbale Texture2D to work.");
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2F05FB0", Offset = "0x2F049B0", VA = "0x182F05FB0", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		RectTransform rectTransform = _image.rectTransform;
		Vector2 pivot = _image.rectTransform.pivot;
		RectTransform rectTransform2 = _image.rectTransform;
		RectTransform rectTransform3 = _image.rectTransform;
		Sprite sprite = _image.m_Sprite;
		Sprite sprite2 = _image.m_Sprite;
		Sprite sprite3 = _image.m_Sprite;
		Sprite sprite4 = _image.m_Sprite;
		int width = _image.m_Sprite.texture.width;
		int height = _image.m_Sprite.texture.height;
		Texture2D texture = _image.m_Sprite.texture;
		Color color = default(Color);
		float a = color.a;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public AlphaButtonClickMask()
	{
	}
}
