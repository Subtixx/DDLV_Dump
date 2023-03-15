using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003AE")]
	[RequiredAllNotNull]
	public class PendingCookingItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40011FC")]
		[SerializeField]
		private ProgressBar _progressBar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40011FD")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40011FE")]
		[SerializeField]
		private UITimer _mcTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40011FF")]
		[SerializeField]
		private RectTransform _mcTimerContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001200")]
		[SerializeField]
		private TextBase _tfUnknownRecipe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001201")]
		public Button CancelButton;

		[Cpp2IlInjected.Token(Token = "0x600175C")]
		[Cpp2IlInjected.Address(RVA = "0x9B5640", Offset = "0x9B4040", VA = "0x1809B5640")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0011
			CancelButton.m_OnClick.RemoveAllListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x600175D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PendingCookingItem()
		{
		}
	}
}
