using Cpp2IlInjected;
using Gameloft.Rpc.Core;
using Meta.Util;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000EF2")]
	public static class CallContextExtension
	{
		[Cpp2IlInjected.Token(Token = "0x4003D0E")]
		private const string ConflictBefore = "ConflictBefore";

		[Cpp2IlInjected.Token(Token = "0x4003D0F")]
		private const string ConflictAfter = "ConflictAfter";

		[Cpp2IlInjected.Token(Token = "0x6007BAC")]
		[Cpp2IlInjected.Address(RVA = "0x715D60", Offset = "0x714760", VA = "0x180715D60")]
		public static bool ValidateWithChecksum(this MetadataCollection mc)
		{
			//Discarded unreachable code: IL_000c
			return mc.ContainsKey("ClientCrcBefore");
		}

		[Cpp2IlInjected.Token(Token = "0x6007BAD")]
		[Cpp2IlInjected.Address(RVA = "0x715DB0", Offset = "0x7147B0", VA = "0x180715DB0")]
		public static bool ValidateWithProfile(this MetadataCollection mc)
		{
			//Discarded unreachable code: IL_000c
			return mc.ContainsKey("ClientProfileBefore");
		}

		[Cpp2IlInjected.Token(Token = "0x6007BAE")]
		[Cpp2IlInjected.Address(RVA = "0x715C80", Offset = "0x714680", VA = "0x180715C80")]
		public static bool HasConflictBefore(this MetadataCollection mc)
		{
			return mc.IsTrue("ConflictBefore");
		}

		[Cpp2IlInjected.Token(Token = "0x6007BAF")]
		[Cpp2IlInjected.Address(RVA = "0x715D10", Offset = "0x714710", VA = "0x180715D10")]
		public static void SetConflictBefore(this MetadataCollection mc)
		{
			//Discarded unreachable code: IL_000d
			mc.Add("ConflictBefore", value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6007BB0")]
		[Cpp2IlInjected.Address(RVA = "0x715C40", Offset = "0x714640", VA = "0x180715C40")]
		public static bool HasConflictAfter(this MetadataCollection mc)
		{
			return mc.IsTrue("ConflictAfter");
		}

		[Cpp2IlInjected.Token(Token = "0x6007BB1")]
		[Cpp2IlInjected.Address(RVA = "0x715CC0", Offset = "0x7146C0", VA = "0x180715CC0")]
		public static void SetConflictAfter(this MetadataCollection mc)
		{
			//Discarded unreachable code: IL_000d
			mc.Add("ConflictAfter", value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6007BB2")]
		[Cpp2IlInjected.Address(RVA = "0x715BC0", Offset = "0x7145C0", VA = "0x180715BC0")]
		public static bool HasAnyConflict(this MetadataCollection mc)
		{
			if (mc.IsTrue("ConflictBefore"))
			{
				return true;
			}
			return mc.IsTrue("ConflictAfter");
		}
	}
}
