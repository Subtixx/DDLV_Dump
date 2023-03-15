using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	public class ColorItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		internal Color _color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		[SerializeField]
		protected Image mc_colorIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		[SerializeField]
		protected Image mc_colorIconSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		[SerializeField]
		protected bool _isSelected;

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		public virtual bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0xA625A0", Offset = "0xA60FA0", VA = "0x180A625A0", Slot = "4")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5F")]
			[Cpp2IlInjected.Address(RVA = "0x1150940", Offset = "0x114F340", VA = "0x181150940", Slot = "5")]
			set
			{
				//Discarded unreachable code: IL_0022
				_isSelected = value;
				GameObject gameObject = mc_colorIconSelected.gameObject;
				bool isSelected = _isSelected;
				gameObject.SetActive(isSelected);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000A60")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6D0", Offset = "0x8FC0D0", VA = "0x1808FD6D0")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			[Cpp2IlInjected.Token(Token = "0x6000A61")]
			[Cpp2IlInjected.Address(RVA = "0x1150900", Offset = "0x114F300", VA = "0x181150900")]
			set
			{
				//Discarded unreachable code: IL_0008
				Image image = mc_colorIcon;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ColorItem()
		{
		}
	}
}
