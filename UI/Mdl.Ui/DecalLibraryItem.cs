using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000413")]
	[RequiredAllNotNull]
	public class DecalLibraryItem : DecalBaseItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400146F")]
		[SerializeField]
		private RectTransform _mcColorIcon;

		[Cpp2IlInjected.Token(Token = "0x6001A7E")]
		[Cpp2IlInjected.Address(RVA = "0x12B5090", Offset = "0x12B3A90", VA = "0x1812B5090", Slot = "4")]
		public override void Init(DecalItemData decalData, Color color, int layer)
		{
			//Discarded unreachable code: IL_001b
			GameObject gameObject = _mcColorIcon.gameObject;
			bool allowColoring_ = decalData.allowColoring_;
			gameObject.SetActive(allowColoring_);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A7F")]
		[Cpp2IlInjected.Address(RVA = "0x12AFF20", Offset = "0x12AE920", VA = "0x1812AFF20")]
		public DecalLibraryItem()
		{
		}
	}
}
