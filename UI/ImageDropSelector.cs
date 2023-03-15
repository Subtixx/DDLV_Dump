using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

[Cpp2IlInjected.Token(Token = "0x200004F")]
public class ImageDropSelector : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[SerializeField]
	[FormerlySerializedAs("imgref")]
	private Image imgref;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[SerializeField]
	[FormerlySerializedAs("cild")]
	private Image cild;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[SerializeField]
	[FormerlySerializedAs("spriteref")]
	private Sprite spriteref;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[SerializeField]
	[FormerlySerializedAs("istoggle")]
	[Header("Toggle")]
	private bool _isToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[SerializeField]
	[FormerlySerializedAs("toggleref")]
	private Toggle _toggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[SerializeField]
	[FormerlySerializedAs("Highligh")]
	private bool _isHighlighted;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[SerializeField]
	[FormerlySerializedAs("spriteToggle_HI")]
	private Sprite _spriteToggleHighlight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[SerializeField]
	[FormerlySerializedAs("spriteToggle_NO")]
	private Sprite _spriteToggleNormal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[SerializeField]
	[Header("Label")]
	[FormerlySerializedAs("Label")]
	private Text _label;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[SerializeField]
	[FormerlySerializedAs("Label_HI")]
	private Color _labelColorHighlight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[SerializeField]
	[FormerlySerializedAs("Label_NO")]
	private Color _labelColorNormal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private Image _image;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x130FE50", Offset = "0x130E850", VA = "0x18130FE50")]
	private void Awake()
	{
		Image image = (_image = GetComponent<Image>());
		/*Error: Unexpected end of block*/;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1310250", Offset = "0x130EC50", VA = "0x181310250")]
	public void setboolhigh(bool value)
	{
		Debug.Log(string.Format("[UI] setboolhigh {0}", "[UI] setboolhigh {0}"));
		_isHighlighted = value;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x130FEA0", Offset = "0x130E8A0", VA = "0x18130FEA0")]
	public void HighlightText(bool highlight)
	{
		//Discarded unreachable code: IL_001a
		Text label = _label;
		if (highlight)
		{
		}
		Color color = (label.color = _labelColorNormal);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x130FEF0", Offset = "0x130E8F0", VA = "0x18130FEF0")]
	private void Update()
	{
		//IL_00de: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			if (_isToggle)
			{
				Toggle toggle = _toggle;
				Text label = _label;
				if (!toggle.m_IsOn)
				{
					Color labelColorNormal = _labelColorNormal;
					if (flag)
					{
						Image image = _image;
						Sprite sprite = (image.sprite = _spriteToggleNormal);
					}
					return;
				}
				Color labelColorHighlight = _labelColorHighlight;
				if (flag2)
				{
					Image image2 = _image;
					Sprite sprite2 = (image2.sprite = _spriteToggleHighlight);
				}
				Text label2 = _label;
				Color color = (label2.color = _labelColorHighlight);
				return;
			}
			Sprite sprite3 = imgref.m_Sprite;
			Sprite sprite4 = spriteref;
			if (sprite3 == sprite4 && !_isHighlighted)
			{
				Image image3 = _image;
				int num = ((image3.enabled = false) ? 1 : 0);
				Image image4 = cild;
				int num2 = 0;
				if (image4 != (UnityEngine.Object)num2)
				{
					Image image5 = cild;
					int num3 = ((image5.enabled = false) ? 1 : 0);
				}
				return;
			}
			_image.enabled = true;
			Image image6 = cild;
			int num4 = 0;
			if (!(image6 != (UnityEngine.Object)num4))
			{
				continue;
			}
			Transform transform = imgref.transform.Find("Dropdown List");
			int num5 = 0;
			if (transform == (UnityEngine.Object)num5)
			{
				while (!_isHighlighted)
				{
				}
				Sprite sprite5 = imgref.m_Sprite;
				Sprite sprite6 = spriteref;
				if (sprite5 == sprite6)
				{
					break;
				}
			}
		}
		Image image7 = cild;
		throw new NullReferenceException();
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
	public ImageDropSelector()
	{
	}
}
