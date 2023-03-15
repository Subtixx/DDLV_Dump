using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Mdl.Ui;
using Mdl.Ui.Photo;
using UnityEngine;
using UnityEngine.UI;

[Cpp2IlInjected.Token(Token = "0x200004A")]
public class PhotoFrame : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public enum Type
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		Nineslice,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		Corner,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		Orientation,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		TopLeft,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		TopRight,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		BottomLeft,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		BottomRight,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Cinematic
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public GameObject ninesliceFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public GameObject cornerFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public GameObject orientationFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public GameObject fixedPositionFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public GameObject cinematicFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public List<PhotoFrameData> listFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public int currentFrame = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public Vector2 iconSize = (Vector2)1140457472;

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x9C04C0", Offset = "0x9BEEC0", VA = "0x1809C04C0")]
	public void RemoveFrame()
	{
		//Discarded unreachable code: IL_00f3
		Transform transform = ninesliceFrame.transform;
		Transform transform3 = (transform.parent = base.transform);
		Transform transform4 = cornerFrame.transform;
		Transform transform6 = (transform4.parent = base.transform);
		Transform transform7 = orientationFrame.transform;
		Transform transform9 = (transform7.parent = base.transform);
		Transform transform10 = fixedPositionFrame.transform;
		Transform transform12 = (transform10.parent = base.transform);
		Transform transform13 = cinematicFrame.transform;
		Transform transform15 = (transform13.parent = base.transform);
		GameObject gameObject = ninesliceFrame;
		int active = 0;
		gameObject.SetActive((byte)active != 0);
		GameObject gameObject2 = cornerFrame;
		int active2 = 0;
		gameObject2.SetActive((byte)active2 != 0);
		GameObject gameObject3 = orientationFrame;
		int active3 = 0;
		gameObject3.SetActive((byte)active3 != 0);
		GameObject gameObject4 = fixedPositionFrame;
		int active4 = 0;
		gameObject4.SetActive((byte)active4 != 0);
		GameObject gameObject5 = cinematicFrame;
		int active5 = 0;
		gameObject5.SetActive((byte)active5 != 0);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x9BFD90", Offset = "0x9BE790", VA = "0x1809BFD90")]
	public void AddFrame(PhotoFrameData photoFrameData, PhotoModeImageFormat format, Transform parent, Vector2 frameSize, int siblingIndex)
	{
		//IL_0011: Expected O, but got I4
		//IL_0149: Expected I4, but got I8
		//IL_016b: Expected F4, but got I4
		//IL_0177: Expected F4, but got I4
		//IL_0183: Expected F4, but got I4
		//IL_018f: Expected F4, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected F4, but got Unknown
		//IL_01ec: Expected I4, but got I8
		//IL_0212: Expected F4, but got I4
		//IL_021e: Expected F4, but got I4
		//IL_022a: Expected F4, but got I4
		//IL_0236: Expected F4, but got I4
		RemoveFrame();
		int num = 0;
		bool flag = photoFrameData == (UnityEngine.Object)num;
		if (flag)
		{
			return;
		}
		GameObject gameObject = ninesliceFrame;
		Type type = photoFrameData.type;
		if ((flag ? 1 : 0) > (true ? 1 : 0))
		{
			if (type != 0)
			{
				if (type != Type.Corner)
				{
					if (type != Type.Orientation)
					{
						if (type != Type.Cinematic)
						{
							goto IL_0140;
						}
						Image[] componentsInChildren = cinematicFrame.GetComponentsInChildren<Image>();
						int num2 = 0;
						int length = componentsInChildren.Length;
						if (num2 < length)
						{
							Image image = componentsInChildren[num2];
							Sprite sprite2 = (image.sprite = photoFrameData.sprite);
							num2++;
						}
					}
					Image component = orientationFrame.GetComponent<Image>();
					if (format != 0)
					{
						if (format != PhotoModeImageFormat.Landscape)
						{
							if (format != PhotoModeImageFormat.Portrait)
							{
								goto IL_00d9;
							}
							Sprite sprite3 = (component.sprite = photoFrameData.spritePortrait);
						}
						Sprite sprite4 = (component.sprite = photoFrameData.spriteLandscape);
					}
					Sprite sprite5 = (component.sprite = photoFrameData.spriteSquare);
				}
				goto IL_00d9;
			}
			goto IL_011a;
		}
		Vector2 vector = iconSize;
		float y = iconSize.y;
		float num3 = (float)(vector * 0.5f);
		Image component2 = fixedPositionFrame.GetComponent<Image>();
		Sprite sprite7 = (component2.sprite = photoFrameData.sprite);
		GameObject gameObject2 = fixedPositionFrame;
		ulong num4 = default(ulong);
		gameObject2.SetActive((byte)num4 != 0);
		Transform transform = gameObject2.transform;
		transform.parent = parent;
		RectTransform component3 = gameObject2.GetComponent<RectTransform>();
		int num5 = 0;
		component3.SetLeft(num5);
		int num6 = 0;
		component3.SetRight(num6);
		int num7 = 0;
		component3.SetTop(num7);
		int num8 = 0;
		component3.SetBottom(num8);
		Type type2 = photoFrameData.type;
		if ((object)transform != null)
		{
			if ((object)transform != null)
			{
				if ((object)transform != null)
				{
					if (type2 != Type.Corner)
					{
						goto IL_02c0;
					}
					component3.SetRight(num3);
					component3.SetBottom(num3);
				}
				int num9 = 0;
				Vector2 vector2 = (component3.anchorMax = Vector2.zero);
				int num10 = 0;
				Vector2 vector4 = (component3.sizeDelta = (component3.anchorMin = Vector2.zero));
				component3.SetLeft(num3);
				component3.SetBottom(num3);
			}
			component3.SetRight(num3);
		}
		component3.SetLeft(num3);
		component3.SetTop(num3);
		goto IL_02c0;
		IL_00d9:
		Image[] componentsInChildren2 = cornerFrame.GetComponentsInChildren<Image>();
		int num11 = 0;
		int length2 = componentsInChildren2.Length;
		if (num11 < length2)
		{
			Image image2 = componentsInChildren2[num11];
			Sprite sprite9 = (image2.sprite = photoFrameData.sprite);
			num11++;
		}
		goto IL_011a;
		IL_011a:
		Image component4 = gameObject.GetComponent<Image>();
		Sprite sprite11 = (component4.sprite = photoFrameData.sprite);
		GameObject gameObject3 = ninesliceFrame.gameObject;
		goto IL_0140;
		IL_0140:
		ulong num12 = default(ulong);
		gameObject3.SetActive((byte)num12 != 0);
		gameObject3.transform.parent = parent;
		RectTransform component5 = gameObject3.GetComponent<RectTransform>();
		int num13 = 0;
		component5.SetLeft(num13);
		int num14 = 0;
		component5.SetRight(num14);
		int num15 = 0;
		component5.SetTop(num15);
		int num16 = 0;
		component5.SetBottom(num16);
		Transform transform2 = gameObject3.gameObject.transform;
		return;
		IL_02c0:
		Vector2 sizeDelta = iconSize;
		float y2 = iconSize.y;
		component3.sizeDelta = sizeDelta;
		Transform transform3 = gameObject2.gameObject.transform;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x9C0650", Offset = "0x9BF050", VA = "0x1809C0650")]
	public unsafe PhotoFrame()
	{
		//IL_0010: Expected I4, but got I8
		//IL_001d: Expected O, but got I8
		//IL_0028: Expected native int or pointer, but got O
		((Vector2*)(IntPtr)iconSize)->y = 200f;
		base._002Ector();
	}
}
