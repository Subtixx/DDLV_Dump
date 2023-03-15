using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000245")]
	public class UIErrorMessage : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000A21")]
		public int TweakErrorMessageLimit = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000A22")]
		[SerializeField]
		private UIErrorMessageItem _messagePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000A23")]
		[SerializeField]
		private RectTransform _messageHolder;

		[Cpp2IlInjected.Token(Token = "0x170002C8")]
		public RectTransform MessageHolder
		{
			[Cpp2IlInjected.Token(Token = "0x6000E5D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _messageHolder;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5E")]
		[Cpp2IlInjected.Address(RVA = "0xC95B20", Offset = "0xC94520", VA = "0x180C95B20")]
		public void ShowMessage(string message, float duration = 0.7f, bool showDuplicates = false)
		{
			//Discarded unreachable code: IL_00d2
			if (TweakErrorMessageLimit > 0)
			{
				int childCount = _messageHolder.childCount;
				RectTransform messageHolder = _messageHolder;
				int index = 0;
				UnityEngine.Object.Destroy(messageHolder.GetChild(index).gameObject);
			}
			if (!showDuplicates && _messageHolder.childCount > 0)
			{
				RectTransform messageHolder2 = _messageHolder;
				int num = 0;
				int childCount2 = messageHolder2.childCount;
				if (num < childCount2)
				{
					int childCount3 = _messageHolder.childCount;
					if (num < childCount3)
					{
						UIErrorMessageItem component = _messageHolder.GetChild(num).GetComponent<UIErrorMessageItem>();
						string stringID = component.Label._stringID;
						if ((object)component != null)
						{
							return;
						}
						RectTransform messageHolder3 = _messageHolder;
						num++;
					}
				}
			}
			UIErrorMessageItem messagePrefab = _messagePrefab;
			RectTransform messageHolder4 = _messageHolder;
			UIErrorMessageItem uIErrorMessageItem = UnityEngine.Object.Instantiate(messagePrefab, messageHolder4);
			uIErrorMessageItem.Label.StringID = message;
			uIErrorMessageItem.Show(duration);
		}

		[Cpp2IlInjected.Token(Token = "0x6000E5F")]
		[Cpp2IlInjected.Address(RVA = "0xC95D50", Offset = "0xC94750", VA = "0x180C95D50")]
		private bool VerifyIfDuplicate(string message)
		{
			RectTransform messageHolder = _messageHolder;
			int num = 0;
			if (messageHolder.childCount > 0)
			{
				RectTransform messageHolder2 = _messageHolder;
				int num2 = 0;
				int childCount = messageHolder2.childCount;
				if (num2 < childCount)
				{
					int childCount2 = _messageHolder.childCount;
					if (num2 < childCount2 && !string.Equals(_messageHolder.GetChild(num2).GetComponent<UIErrorMessageItem>().Label._stringID, message))
					{
						RectTransform messageHolder3 = _messageHolder;
						num2++;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000E60")]
		[Cpp2IlInjected.Address(RVA = "0xC95E70", Offset = "0xC94870", VA = "0x180C95E70")]
		public UIErrorMessage()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
