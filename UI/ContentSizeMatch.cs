using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000032")]
[ExecuteInEditMode]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class ContentSizeMatch : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[SerializeField]
	private RectTransform _targetRectTransform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[SerializeField]
	private bool _matchWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[SerializeField]
	private bool _matchHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[SerializeField]
	private float _widthDelta;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[SerializeField]
	private float _heightDelta;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private RectTransform _rt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private float _targetWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private float _targetHeight;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float WidthDelta
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF70", Offset = "0xA7C970", VA = "0x180A7DF70")]
		get
		{
			return _widthDelta;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF90", Offset = "0xA7C990", VA = "0x180A7DF90")]
		set
		{
			_widthDelta = value;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public float HeightDelta
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF60", Offset = "0xA7C960", VA = "0x180A7DF60")]
		get
		{
			return _heightDelta;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA7DF80", Offset = "0xA7C980", VA = "0x180A7DF80")]
		set
		{
			_heightDelta = value;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x14A3690", Offset = "0x14A2090", VA = "0x1814A3690")]
	private void Awake()
	{
		RectTransform rectTransform = (_rt = GetComponent<RectTransform>());
		applyMatchSize();
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x14A36F0", Offset = "0x14A20F0", VA = "0x1814A36F0")]
	private void OnRectTransformDimensionsChange()
	{
		applyMatchSize();
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x14A36F0", Offset = "0x14A20F0", VA = "0x1814A36F0")]
	private void OnEnable()
	{
		applyMatchSize();
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x14A36F0", Offset = "0x14A20F0", VA = "0x1814A36F0")]
	private void OnValidate()
	{
		applyMatchSize();
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x14A3700", Offset = "0x14A2100", VA = "0x1814A3700")]
	private void applyMatchSize()
	{
		//Discarded unreachable code: IL_00ce
		//IL_0010: Expected O, but got I4
		//IL_0026: Expected O, but got I4
		//IL_0068: Expected F4, but got O
		//IL_007d: Expected O, but got I4
		//IL_00b8: Expected F4, but got I4
		//IL_00cd: Expected O, but got I4
		RectTransform rt = _rt;
		int num = 0;
		if (!(rt != (Object)num))
		{
			return;
		}
		RectTransform targetRectTransform = _targetRectTransform;
		int num2 = 0;
		if (!(targetRectTransform != (Object)num2))
		{
			return;
		}
		if (_matchWidth)
		{
			RectTransform targetRectTransform2 = _targetRectTransform;
			Vector2 sizeDelta = targetRectTransform2.sizeDelta;
			if ((object)targetRectTransform2 != null)
			{
				Vector2 sizeDelta2 = _targetRectTransform.sizeDelta;
				RectTransform rt2 = _rt;
				_targetWidth = (float)sizeDelta2;
				int num3 = 0;
				Vector2 sizeDelta3 = rt2.sizeDelta;
				rt2.sizeDelta = (Vector2)num3;
			}
		}
		if (_matchHeight)
		{
			RectTransform targetRectTransform3 = _targetRectTransform;
			Vector2 sizeDelta4 = targetRectTransform3.sizeDelta;
			if ((object)targetRectTransform3 != null)
			{
				Vector2 sizeDelta5 = _targetRectTransform.sizeDelta;
				RectTransform rt3 = _rt;
				_targetHeight = 0f;
				int num4 = 0;
				Vector2 sizeDelta6 = rt3.sizeDelta;
				rt3.sizeDelta = (Vector2)num4;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x14A36F0", Offset = "0x14A20F0", VA = "0x1814A36F0")]
	private void Update()
	{
		applyMatchSize();
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public ContentSizeMatch()
	{
	}
}
