using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20009A6")]
	public class GardeningDetail
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027E3")]
		public bool inVillage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40027E4")]
		public bool burningState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40027E5")]
		public int? criticalSuccessMinigameID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40027E6")]
		public bool automatic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
		[Cpp2IlInjected.Token(Token = "0x40027E7")]
		public bool wasDry;

		[Cpp2IlInjected.Token(Token = "0x6005468")]
		[Cpp2IlInjected.Address(RVA = "0x1D021B0", Offset = "0x1D00BB0", VA = "0x181D021B0")]
		public GardeningDetail(bool inVillage, bool burningState = false, [Optional] int? criticalSuccessMinigameID, bool automatic = false, bool wasDry = false)
		{
			this.automatic = false;
			this.burningState = burningState;
			this.criticalSuccessMinigameID = criticalSuccessMinigameID;
			this.wasDry = false;
			this.inVillage = inVillage;
		}
	}
}
