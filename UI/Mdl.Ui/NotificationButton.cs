using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	public class NotificationButton : BaseButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		[SerializeField]
		public Image _iconAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		[SerializeField]
		private RedDot _notificationAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		[SerializeField]
		private Material _greyMaterial;

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public Image IconAsset
		{
			[Cpp2IlInjected.Token(Token = "0x60009E9")]
			[Cpp2IlInjected.Address(RVA = "0x129F680", Offset = "0x129E080", VA = "0x18129F680")]
			get
			{
				return _iconAsset;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public RedDot NotificationAsset
		{
			[Cpp2IlInjected.Token(Token = "0x60009EA")]
			[Cpp2IlInjected.Address(RVA = "0x129F690", Offset = "0x129E090", VA = "0x18129F690")]
			get
			{
				return _notificationAsset;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x129F5D0", Offset = "0x129DFD0", VA = "0x18129F5D0", Slot = "16")]
		public override void RefreshActive()
		{
			//Discarded unreachable code: IL_002f
			//IL_0016: Expected O, but got I4
			base.RefreshActive();
			Image iconAsset = _iconAsset;
			int num = 0;
			if (iconAsset != (Object)num)
			{
				Image iconAsset2 = _iconAsset;
				Material material = (iconAsset2.material = _greyMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x855CC0", Offset = "0x8546C0", VA = "0x180855CC0")]
		public NotificationButton()
		{
		}
	}
}
