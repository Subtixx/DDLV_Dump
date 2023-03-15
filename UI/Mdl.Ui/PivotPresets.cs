using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200085E")]
	public class PivotPresets
	{
		[Cpp2IlInjected.Token(Token = "0x4003122")]
		public static readonly Vector2 TopLeft;

		[Cpp2IlInjected.Token(Token = "0x4003123")]
		public static readonly Vector2 TopCenter;

		[Cpp2IlInjected.Token(Token = "0x4003124")]
		public static readonly Vector2 TopRight;

		[Cpp2IlInjected.Token(Token = "0x4003125")]
		public static readonly Vector2 MiddleLeft;

		[Cpp2IlInjected.Token(Token = "0x4003126")]
		public static readonly Vector2 MiddleCenter;

		[Cpp2IlInjected.Token(Token = "0x4003127")]
		public static readonly Vector2 MiddleRight;

		[Cpp2IlInjected.Token(Token = "0x4003128")]
		public static readonly Vector2 BottomLeft;

		[Cpp2IlInjected.Token(Token = "0x4003129")]
		public static readonly Vector2 BottomCenter;

		[Cpp2IlInjected.Token(Token = "0x400312A")]
		public static readonly Vector2 BottomRight;

		[Cpp2IlInjected.Token(Token = "0x60034E8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PivotPresets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60034E9")]
		[Cpp2IlInjected.Address(RVA = "0xE0F7F0", Offset = "0xE0E1F0", VA = "0x180E0F7F0")]
		static PivotPresets()
		{
			//IL_0008: Expected O, but got I4
			//IL_000e: Expected O, but got I4
			//IL_0014: Expected O, but got I4
			int num = 0;
			TopLeft = (Vector2)num;
			MiddleLeft = (Vector2)num;
			BottomLeft = (Vector2)num;
		}
	}
}
