using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	public class ShortcutIndicatorView : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400086C")]
		public GameObject BackgroundHolderObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400086D")]
		public GameObject BackgroundObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400086E")]
		public GameObject IconObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400086F")]
		public TMP_Text Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000870")]
		public TMP_Text AdditionalLabel;

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x15ECB70", Offset = "0x15EB570", VA = "0x1815ECB70")]
		public float GetContentWidth()
		{
			//Discarded unreachable code: IL_0044
			RectTransform component = BackgroundHolderObject.GetComponent<RectTransform>();
			if (AdditionalLabel.gameObject.activeSelf)
			{
				TMP_Text additionalLabel = AdditionalLabel;
				int forceTextReparsing = 0;
				int ignoreActiveState = 0;
				additionalLabel.ForceMeshUpdate((byte)ignoreActiveState != 0, (byte)forceTextReparsing != 0);
				float preferredWidth = AdditionalLabel.preferredWidth;
			}
			float result = default(float);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ShortcutIndicatorView()
		{
		}
	}
}
