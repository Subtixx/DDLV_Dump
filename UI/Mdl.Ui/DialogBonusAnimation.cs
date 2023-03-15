using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200041A")]
	public class DialogBonusAnimation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001493")]
		[SerializeField]
		private Image _mcAnimateBg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001494")]
		[SerializeField]
		private TextBase _tfXpBonus;

		[Cpp2IlInjected.Token(Token = "0x1700044C")]
		public Image AnimatedBackground
		{
			[Cpp2IlInjected.Token(Token = "0x6001A9B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _mcAnimateBg;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A9C")]
		[Cpp2IlInjected.Address(RVA = "0x12B86D0", Offset = "0x12B70D0", VA = "0x1812B86D0")]
		public void RefreshDisplay(int xp)
		{
			//Discarded unreachable code: IL_0039
			//IL_0012: Expected O, but got I4
			Image mcAnimateBg = _mcAnimateBg;
			int num = 0;
			int num2 = 0;
			mcAnimateBg.color = (Color)num2;
			Transform transform = _mcAnimateBg.transform;
			float z = Vector3.zero.z;
			string text = default(string);
			_tfXpBonus.Text = text;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A9D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DialogBonusAnimation()
		{
		}
	}
}
