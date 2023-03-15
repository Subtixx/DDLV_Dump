using System;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	public class OnlineDataFileInfo
	{
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public static readonly string SPECIAL_FILE_PLAYER_PROFILE = "sf_player_profile";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public string filename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public bool canBeEncrypted;

		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public static OnlineDataFileInfo ClientProfileFileInfo;

		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		public static OnlineDataFileInfo KeyChainFileInfo;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x116EAB0", Offset = "0x116D4B0", VA = "0x18116EAB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
				int num = 0;
				int num2 = 0;
				if (obj != null && filename != null)
				{
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x116EB90", Offset = "0x116D590", VA = "0x18116EB90")]
		public bool IsPlayerProfile()
		{
			string text = filename;
			if (text == null)
			{
				int num = 0;
			}
			string sPECIAL_FILE_PLAYER_PROFILE = SPECIAL_FILE_PLAYER_PROFILE;
			return text.Equals(sPECIAL_FILE_PLAYER_PROFILE);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public OnlineDataFileInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x116EC10", Offset = "0x116D610", VA = "0x18116EC10")]
		static OnlineDataFileInfo()
		{
			OnlineDataFileInfo onlineDataFileInfo = new OnlineDataFileInfo();
			string text = (onlineDataFileInfo.filename = SPECIAL_FILE_PLAYER_PROFILE);
			onlineDataFileInfo.canBeEncrypted = true;
			SPECIAL_FILE_PLAYER_PROFILE = (string)(object)onlineDataFileInfo;
			SPECIAL_FILE_PLAYER_PROFILE = (string)(object)new OnlineDataFileInfo
			{
				filename = "keychain.json",
				canBeEncrypted = false
			};
			throw new NullReferenceException();
		}
	}
}
