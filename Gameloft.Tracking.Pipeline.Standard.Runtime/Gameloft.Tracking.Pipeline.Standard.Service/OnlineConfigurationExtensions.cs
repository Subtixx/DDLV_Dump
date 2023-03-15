using Cpp2IlInjected;
using Gameloft.Tracking.Service;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class OnlineConfigurationExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x28C38F0", Offset = "0x28C22F0", VA = "0x1828C38F0")]
		public static OnlineConfiguration WithDataCenter(this OnlineConfiguration config, string dcid)
		{
			//Discarded unreachable code: IL_000d
			return config.WithCustomField("data_center_id", dcid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x28C3890", Offset = "0x28C2290", VA = "0x1828C3890")]
		public static OnlineConfiguration WithAnonymous(this OnlineConfiguration config, string anonid)
		{
			//Discarded unreachable code: IL_000d
			return config.WithCustomField("anon_id", anonid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x28C3950", Offset = "0x28C2350", VA = "0x1828C3950")]
		public static OnlineConfiguration WithGDID(this OnlineConfiguration config, string gdid)
		{
			//Discarded unreachable code: IL_000d
			return config.WithCustomField("gdid", gdid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x28C3A10", Offset = "0x28C2410", VA = "0x1828C3A10")]
		public static OnlineConfiguration WithIDFV(this OnlineConfiguration config, string idfv)
		{
			//Discarded unreachable code: IL_000d
			return config.WithCustomField("idfv", idfv);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x28C39B0", Offset = "0x28C23B0", VA = "0x1828C39B0")]
		public static OnlineConfiguration WithHDIDFV(this OnlineConfiguration config, string hdidfv)
		{
			//Discarded unreachable code: IL_000d
			return config.WithCustomField("hdidfv", hdidfv);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x28C3A70", Offset = "0x28C2470", VA = "0x1828C3A70")]
		public static OnlineConfiguration WithPlatform(this OnlineConfiguration config, PlatformID platform)
		{
			//Discarded unreachable code: IL_000d
			string value = default(string);
			return config.WithCustomField("platform", value);
		}
	}
}
