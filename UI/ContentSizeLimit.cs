using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000031")]
[ExecuteAlways]
[ExecuteInEditMode]
[RequireComponent(typeof(RectTransform))]
public class ContentSizeLimit : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[SerializeField]
	private bool _useMinWitdh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[SerializeField]
	private int _minWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[SerializeField]
	private bool _useMaxWitdh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[SerializeField]
	private int _maxWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private RectTransform _rt;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x14A34D0", Offset = "0x14A1ED0", VA = "0x1814A34D0")]
	private void Awake()
	{
		RectTransform rectTransform = (_rt = GetComponent<RectTransform>());
		applyMaxSize();
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x14A3530", Offset = "0x14A1F30", VA = "0x1814A3530")]
	private void OnRectTransformDimensionsChange()
	{
		applyMaxSize();
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x14A3530", Offset = "0x14A1F30", VA = "0x1814A3530")]
	private void OnEnable()
	{
		applyMaxSize();
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x14A3530", Offset = "0x14A1F30", VA = "0x1814A3530")]
	private void OnValidate()
	{
		applyMaxSize();
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x14A3540", Offset = "0x14A1F40", VA = "0x1814A3540")]
	private void applyMaxSize()
	{
		//Discarded unreachable code: IL_0076
		//IL_0010: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		RectTransform rt = _rt;
		int num = 0;
		if (rt != (Object)num)
		{
			if (_useMinWitdh)
			{
				Vector2 sizeDelta = _rt.sizeDelta;
				RectTransform rt2 = _rt;
				int num2 = 0;
				Vector2 sizeDelta2 = rt2.sizeDelta;
				rt2.sizeDelta = (Vector2)num2;
			}
			if (_useMaxWitdh)
			{
				Vector2 sizeDelta3 = _rt.sizeDelta;
				RectTransform rt3 = _rt;
				int num3 = 0;
				Vector2 sizeDelta4 = rt3.sizeDelta;
				rt3.sizeDelta = (Vector2)num3;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public ContentSizeLimit()
	{
	}
}
