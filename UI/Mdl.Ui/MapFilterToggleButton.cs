using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200062E")]
	public class MapFilterToggleButton : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400226C")]
		public UnityEvent OnActivate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400226D")]
		public UnityEvent OnDeactivate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400226E")]
		public bool _isSelected = true;

		[Cpp2IlInjected.Token(Token = "0x1700060C")]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6002843")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return _isSelected;
			}
			[Cpp2IlInjected.Token(Token = "0x6002844")]
			[Cpp2IlInjected.Address(RVA = "0x117CC30", Offset = "0x117B630", VA = "0x18117CC30")]
			set
			{
				_isSelected = value;
				if (!value)
				{
				}
				OnActivate?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002845")]
		[Cpp2IlInjected.Address(RVA = "0x117CBF0", Offset = "0x117B5F0", VA = "0x18117CBF0")]
		public void OnClicked()
		{
			bool isSelected = _isSelected;
			bool flag = (_isSelected = !isSelected);
			if (isSelected)
			{
			}
			OnActivate?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6002846")]
		[Cpp2IlInjected.Address(RVA = "0x117CC20", Offset = "0x117B620", VA = "0x18117CC20")]
		public MapFilterToggleButton()
		{
		}
	}
}
