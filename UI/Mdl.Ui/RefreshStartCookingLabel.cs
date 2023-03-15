using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003BD")]
	public class RefreshStartCookingLabel : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001253")]
		[SerializeField]
		private GameObject _coalCostRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001254")]
		[SerializeField]
		private GameObject _defaultLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4001255")]
		[SerializeField]
		private GameObject _centerLabel;

		[Cpp2IlInjected.Token(Token = "0x60017C9")]
		[Cpp2IlInjected.Address(RVA = "0xE2EFD0", Offset = "0xE2D9D0", VA = "0x180E2EFD0")]
		public void Refresh(bool value)
		{
			//Discarded unreachable code: IL_007c
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			GameObject coalCostRoot = _coalCostRoot;
			int num = 0;
			if (!(coalCostRoot != (Object)num))
			{
				return;
			}
			GameObject defaultLabel = _defaultLabel;
			int num2 = 0;
			if (defaultLabel != (Object)num2)
			{
				GameObject centerLabel = _centerLabel;
				int num3 = 0;
				if (centerLabel != (Object)num3)
				{
					_coalCostRoot.SetActive(value);
					_defaultLabel.SetActive(value);
					_centerLabel.SetActive(value);
					TMP_Text component = _centerLabel.GetComponent<TMP_Text>();
					TMP_Text component2 = _defaultLabel.GetComponent<TMP_Text>();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60017CA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public RefreshStartCookingLabel()
		{
		}
	}
}
