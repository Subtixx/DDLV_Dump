using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using Mdl.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003AF")]
	[RequiredAllNotNull]
	public class PendingRecipeItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20003B0")]
		public delegate void OnRemoveDelegate(PendingRecipeItem item);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001202")]
		[SerializeField]
		private TextBase _tfEmptyLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001203")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001204")]
		[SerializeField]
		private AsyncAtlassedIcon _mcIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4001205")]
		[SerializeField]
		protected Image _mcBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4001206")]
		public OnRemoveDelegate OnRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4001207")]
		public UnityEvent OnRefreshDisplay;

		[Cpp2IlInjected.Token(Token = "0x170003EE")]
		public Button CloseAsset
		{
			[Cpp2IlInjected.Token(Token = "0x600175E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return _btnClose;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600175F")]
		[Cpp2IlInjected.Address(RVA = "0x9B5870", Offset = "0x9B4270", VA = "0x1809B5870")]
		private void Start()
		{
			//Discarded unreachable code: IL_0021
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = OnRemoveClickHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001760")]
		[Cpp2IlInjected.Address(RVA = "0x9B5690", Offset = "0x9B4090", VA = "0x1809B5690")]
		public void SetEmpty()
		{
			//Discarded unreachable code: IL_00ab
			//IL_0029: Expected O, but got I4
			GameObject gameObject = _mcIcon.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			TextBase tfEmptyLabel = _tfEmptyLabel;
			int num = 0;
			string text2 = (tfEmptyLabel.Text = LocalizationManager.FromStringID("menu.common_empty", (IResolver)num));
			_tfEmptyLabel.TextComponent.fontSizeMax = 30f;
			TextMeshProUGUI textComponent = _tfEmptyLabel.TextComponent;
			Color white = Color.white;
			_tfEmptyLabel.gameObject.SetActive(value: true);
			Image mcBackground = _mcBackground;
			int num2 = 0;
			GameObject gameObject2 = _mcIcon.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			GameObject gameObject3 = _btnClose.gameObject;
			int active3 = 0;
			gameObject3.SetActive((byte)active3 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001761")]
		[Cpp2IlInjected.Address(RVA = "0x9B5670", Offset = "0x9B4070", VA = "0x1809B5670")]
		private void OnRemoveClickHandler()
		{
			OnRemove?.Invoke(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001762")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public PendingRecipeItem()
		{
		}
	}
}
