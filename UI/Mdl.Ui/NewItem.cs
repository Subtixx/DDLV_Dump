using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000361")]
	[RequiredAllNotNull]
	public class NewItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001058")]
		[SerializeField]
		private AsyncAtlassedIcon mc_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001059")]
		[SerializeField]
		private StarComponent _mcStarComponent;

		[Cpp2IlInjected.Token(Token = "0x600159A")]
		[Cpp2IlInjected.Address(RVA = "0x129A480", Offset = "0x1298E80", VA = "0x18129A480")]
		public void RefreshDisplay(IItemData item)
		{
			//Discarded unreachable code: IL_003a
			AsyncAtlassedIcon asyncAtlassedIcon = mc_icon;
			StarComponent mcStarComponent = _mcStarComponent;
			bool flag = default(bool);
			if (!flag)
			{
				GameObject gameObject = mcStarComponent.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
			}
			else
			{
				mcStarComponent.gameObject.SetActive(value: true);
				StarComponent mcStarComponent2 = _mcStarComponent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600159B")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public NewItem()
		{
		}
	}
}
