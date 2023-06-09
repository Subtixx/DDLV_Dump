using Cpp2IlInjected;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class NonDrawingMaskableGraphic : MaskableGraphic
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "29")]
		public override void SetMaterialDirty()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "28")]
		public override void SetVerticesDirty()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x129C7F0", Offset = "0x129B1F0", VA = "0x18129C7F0", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			//Discarded unreachable code: IL_0007
			vh.Clear();
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x129C870", Offset = "0x129B270", VA = "0x18129C870")]
		public NonDrawingMaskableGraphic()
		{
		}
	}
}
