using System;
using System.Security.AccessControl;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003D6")]
	public class UnityInputProvider : InputProvider
	{
		[Cpp2IlInjected.Token(Token = "0x6001082")]
		[Cpp2IlInjected.Address(RVA = "0x13E33E0", Offset = "0x13E1DE0", VA = "0x1813E33E0", Slot = "4")]
		public override bool GetBool(string inputName)
		{
			return UnityEngine.Input.GetButton(inputName);
		}

		[Cpp2IlInjected.Token(Token = "0x6001083")]
		[Cpp2IlInjected.Address(RVA = "0x13E3400", Offset = "0x13E1E00", VA = "0x1813E3400", Slot = "5")]
		public override float GetFloat(string inputName)
		{
			return UnityEngine.Input.GetAxis(inputName);
		}

		[Cpp2IlInjected.Token(Token = "0x6001084")]
		[Cpp2IlInjected.Address(RVA = "0x13E33F0", Offset = "0x13E1DF0", VA = "0x1813E33F0", Slot = "6")]
		public override float GetFloatRaw(string inputName)
		{
			return UnityEngine.Input.GetAxisRaw(inputName);
		}

		[Cpp2IlInjected.Token(Token = "0x6001085")]
		[Cpp2IlInjected.Address(RVA = "0x13E33A0", Offset = "0x13E1DA0", VA = "0x1813E33A0", Slot = "7")]
		public override Vector2 GetAxis2D(string xInputName, string yInputName)
		{
			float axis = UnityEngine.Input.GetAxis(xInputName);
			float axis2 = UnityEngine.Input.GetAxis(yInputName);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001086")]
		[Cpp2IlInjected.Address(RVA = "0x13E3360", Offset = "0x13E1D60", VA = "0x1813E3360", Slot = "8")]
		public override Vector2 GetAxis2DRaw(string xInputName, string yInputName)
		{
			float axisRaw = UnityEngine.Input.GetAxisRaw(xInputName);
			float axisRaw2 = UnityEngine.Input.GetAxisRaw(yInputName);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001087")]
		[Cpp2IlInjected.Address(RVA = "0x13E3310", Offset = "0x13E1D10", VA = "0x1813E3310", Slot = "9")]
		public override void EnableMaps(params int[] maps)
		{
			NotImplementedException ex = new NotImplementedException("Attempted to enable control maps on UnityInputProvider, but it doesn't support this yet.");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001088")]
		[Cpp2IlInjected.Address(RVA = "0x13E32C0", Offset = "0x13E1CC0", VA = "0x1813E32C0", Slot = "10")]
		public override void DisableMaps(params int[] maps)
		{
			NotImplementedException ex = new NotImplementedException("Attempted to disable control maps on UnityInputProvider, but it doesn't support this yet.");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001089")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public UnityInputProvider()
		{
			((CommonAcl._003C_003Ec__DisplayClass53_0)(object)this)._002Ector();
		}
	}
}
