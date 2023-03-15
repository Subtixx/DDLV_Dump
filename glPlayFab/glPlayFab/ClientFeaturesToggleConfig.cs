using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public class ClientFeaturesToggleConfig : ITitleDataConfig
	{
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private static readonly string TitleDataKeyName = "ClientFeaturesToggle";

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public static readonly string DefaultProfileBackupConfigTitleDataKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public string ProfileBackupPersistenceConfigKey = DefaultProfileBackupConfigTitleDataKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public bool ProfileBackupToGamePortal;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1027640", Offset = "0x1026040", VA = "0x181027640", Slot = "4")]
		public string GetTitleDataConfigKeyName()
		{
			return TitleDataKeyName;
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1027720", Offset = "0x1026120", VA = "0x181027720")]
		public ClientFeaturesToggleConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x10276A0", Offset = "0x10260A0", VA = "0x1810276A0")]
		static ClientFeaturesToggleConfig()
		{
			TitleDataKeyName = "DefaultProfileBackupConfig";
			/*Error: Unexpected end of block*/;
		}
	}
}
