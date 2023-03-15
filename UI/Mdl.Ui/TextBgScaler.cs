using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000899")]
	public class TextBgScaler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200089A")]
		public enum ScaleAxis
		{
			[Cpp2IlInjected.Token(Token = "0x40032DD")]
			Vertical,
			[Cpp2IlInjected.Token(Token = "0x40032DE")]
			Horizontal
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40032D7")]
		[SerializeField]
		private RectTransform _rectTransformToResize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40032D8")]
		[SerializeField]
		private TextMeshProUGUI _text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40032D9")]
		[SerializeField]
		private RectTransform _viewport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40032DA")]
		[SerializeField]
		private ScaleAxis _scaleAxis = ScaleAxis.Horizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40032DB")]
		[SerializeField]
		private float _padding;

		[Cpp2IlInjected.Token(Token = "0x6003629")]
		[Cpp2IlInjected.Address(RVA = "0x17EBB00", Offset = "0x17EA500", VA = "0x1817EBB00")]
		private void Awake()
		{
			//IL_0010: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			RectTransform rectTransformToResize = _rectTransformToResize;
			int num = 0;
			if (rectTransformToResize == (UnityEngine.Object)num)
			{
				RectTransform rectTransform = (_rectTransformToResize = GetComponent<RectTransform>());
			}
			RectTransform viewport = _viewport;
			int num2 = 0;
			if (viewport == (UnityEngine.Object)num2)
			{
				RectTransform rectTransform2 = (_viewport = GetComponent<RectTransform>());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600362A")]
		[Cpp2IlInjected.Address(RVA = "0x17EBBF0", Offset = "0x17EA5F0", VA = "0x1817EBBF0")]
		[ContextMenu("Resize bg")]
		public void Resize()
		{
			//IL_004b: Expected O, but got I4
			TextMeshProUGUI text = _text;
			int forceTextReparsing = 0;
			int ignoreActiveState = 0;
			text.ForceMeshUpdate((byte)ignoreActiveState != 0, (byte)forceTextReparsing != 0);
			ScaleAxis scaleAxis = _scaleAxis;
			if (scaleAxis == ScaleAxis.Vertical)
			{
				TextMeshProUGUI text2 = _text;
				RectTransform rectTransformToResize = _rectTransformToResize;
				Vector2 sizeDelta = rectTransformToResize.sizeDelta;
				RectTransform viewport = _viewport;
				int num = 0;
				rectTransformToResize.sizeDelta = (Vector2)num;
				return;
			}
			while (scaleAxis != ScaleAxis.Horizontal)
			{
			}
			TextMeshProUGUI text3 = _text;
			RectTransform viewport2 = _viewport;
			RectTransform rectTransformToResize2 = _rectTransformToResize;
			float padding = _padding;
			RectTransform rectTransformToResize3 = _rectTransformToResize;
			float num2 = default(float);
			padding = num2;
			Vector2 sizeDelta2 = rectTransformToResize3.sizeDelta;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600362B")]
		[Cpp2IlInjected.Address(RVA = "0x17EBE20", Offset = "0x17EA820", VA = "0x1817EBE20")]
		public TextBgScaler()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
