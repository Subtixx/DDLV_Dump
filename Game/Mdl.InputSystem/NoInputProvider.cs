using System.Security.AccessControl;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003D8")]
	public class NoInputProvider : InputProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6001092")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "4")]
		public override bool GetBool(string inputName)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001093")]
		[Cpp2IlInjected.Address(RVA = "0xCCDB60", Offset = "0xCCC560", VA = "0x180CCDB60", Slot = "5")]
		public override float GetFloat(string inputName)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001094")]
		[Cpp2IlInjected.Address(RVA = "0xCCDB60", Offset = "0xCCC560", VA = "0x180CCDB60", Slot = "6")]
		public override float GetFloatRaw(string inputName)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001095")]
		[Cpp2IlInjected.Address(RVA = "0xF03240", Offset = "0xF01C40", VA = "0x180F03240", Slot = "7")]
		public override Vector2 GetAxis2D(string xInputName, string yInputName)
		{
			int num = 0;
			return Vector2.zero;
		}

		[Cpp2IlInjected.Token(Token = "0x6001096")]
		[Cpp2IlInjected.Address(RVA = "0xF03240", Offset = "0xF01C40", VA = "0x180F03240", Slot = "8")]
		public override Vector2 GetAxis2DRaw(string xInputName, string yInputName)
		{
			int num = 0;
			return Vector2.zero;
		}

		[Cpp2IlInjected.Token(Token = "0x6001097")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "9")]
		public override void EnableMaps(params int[] maps)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001098")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "10")]
		public override void DisableMaps(params int[] maps)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001099")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public NoInputProvider()
		{
			((CommonAcl._003C_003Ec__DisplayClass57_0)(object)this)._002Ector();
		}
	}
}
