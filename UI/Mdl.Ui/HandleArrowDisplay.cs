using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007AA")]
	public class HandleArrowDisplay : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D15")]
		[SerializeField]
		private CanvasGroup _leftArrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D16")]
		[SerializeField]
		private CanvasGroup _rightArrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D17")]
		[SerializeField]
		private LoopScrollRect _loopScrollRect;

		[Cpp2IlInjected.Token(Token = "0x6003107")]
		[Cpp2IlInjected.Address(RVA = "0xAE33B0", Offset = "0xAE1DB0", VA = "0x180AE33B0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_000c
			_loopScrollRect.ResetHorizontalValue();
		}

		[Cpp2IlInjected.Token(Token = "0x6003108")]
		[Cpp2IlInjected.Address(RVA = "0xAE33D0", Offset = "0xAE1DD0", VA = "0x180AE33D0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0060
			//IL_0052: Expected F4, but got I4
			int firstVisibleItemIndex = _loopScrollRect.GetFirstVisibleItemIndex();
			CanvasGroup leftArrow = _leftArrow;
			if (firstVisibleItemIndex == 0)
			{
			}
			leftArrow.alpha = 1f;
			int lastVisibleItemIndex = _loopScrollRect.GetLastVisibleItemIndex();
			int totalCount = _loopScrollRect.totalCount;
			CanvasGroup rightArrow = _rightArrow;
			if (lastVisibleItemIndex == totalCount)
			{
				int num = 0;
				rightArrow.alpha = num;
			}
			else
			{
				rightArrow.alpha = 1f;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003109")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public HandleArrowDisplay()
		{
		}
	}
}
