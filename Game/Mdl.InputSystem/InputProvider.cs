using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003D7")]
	public abstract class InputProvider
	{
		[Cpp2IlInjected.Token(Token = "0x600108A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool GetBool(string inputName);

		[Cpp2IlInjected.Token(Token = "0x600108B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract float GetFloat(string inputName);

		[Cpp2IlInjected.Token(Token = "0x600108C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract float GetFloatRaw(string inputName);

		[Cpp2IlInjected.Token(Token = "0x600108D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract Vector2 GetAxis2D(string axisName1, string axisName2);

		[Cpp2IlInjected.Token(Token = "0x600108E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract Vector2 GetAxis2DRaw(string axisName1, string axisName2);

		[Cpp2IlInjected.Token(Token = "0x600108F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void EnableMaps(params int[] maps);

		[Cpp2IlInjected.Token(Token = "0x6001090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void DisableMaps(params int[] maps);

		[Cpp2IlInjected.Token(Token = "0x6001091")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected InputProvider()
		{
		}
	}
}
