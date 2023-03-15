using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003E5")]
	public class DebugSettingCheckBox : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400132E")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400132F")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001330")]
		[SerializeField]
		private GameObject _mcSelected;

		[Cpp2IlInjected.Token(Token = "0x1700041C")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60018CA")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x60018CB")]
			[Cpp2IlInjected.Address(RVA = "0x1552DC0", Offset = "0x15517C0", VA = "0x181552DC0")]
			set
			{
				//Discarded unreachable code: IL_0014
				_isSelected = value;
				_mcSelected.SetActive(value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700041D")]
		public string Label
		{
			[Cpp2IlInjected.Token(Token = "0x60018CC")]
			[Cpp2IlInjected.Address(RVA = "0x7DAB50", Offset = "0x7D9550", VA = "0x1807DAB50")]
			get
			{
				//Discarded unreachable code: IL_000c
				return _tfLabel._text;
			}
			[Cpp2IlInjected.Token(Token = "0x60018CD")]
			[Cpp2IlInjected.Address(RVA = "0x1552DF0", Offset = "0x15517F0", VA = "0x181552DF0")]
			set
			{
				//Discarded unreachable code: IL_000d
				_tfLabel.Text = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60018CE")]
		[Cpp2IlInjected.Address(RVA = "0x1552D90", Offset = "0x1551790", VA = "0x181552D90")]
		public void OnClicked()
		{
			//Discarded unreachable code: IL_001e
			bool active = (_isSelected = !_isSelected);
			_mcSelected.SetActive(active);
		}

		[Cpp2IlInjected.Token(Token = "0x60018CF")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugSettingCheckBox()
		{
		}
	}
}
