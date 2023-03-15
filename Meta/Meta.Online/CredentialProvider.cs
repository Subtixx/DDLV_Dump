using System;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Meta.Util;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F0E")]
	public class CredentialProvider
	{
		[Cpp2IlInjected.Token(Token = "0x4003D59")]
		private const string UsernameKey = "username";

		[Cpp2IlInjected.Token(Token = "0x4003D5A")]
		private const string GameCustomIDKey = "dev_cid";

		[Cpp2IlInjected.Token(Token = "0x4003D5B")]
		private const string GameloftIDEmailKey = "glid_email";

		[Cpp2IlInjected.Token(Token = "0x4003D5C")]
		private const string GameloftIDPasswordKey = "glid_pwd";

		[Cpp2IlInjected.Token(Token = "0x4003D5D")]
		private const string GameloftIDLinkKey = "glid_link";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003D5E")]
		private bool _newGameCID;

		[Cpp2IlInjected.Token(Token = "0x17001587")]
		public bool IsNewGameCID
		{
			[Cpp2IlInjected.Token(Token = "0x6007C11")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get
			{
				return _newGameCID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001588")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003D5F")]
		private DebugSettings DebugSettings
		{
			[Cpp2IlInjected.Token(Token = "0x6007C12")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001589")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003D60")]
		private IKeyChain KeyChain
		{
			[Cpp2IlInjected.Token(Token = "0x6007C13")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700158A")]
		public string ConfigCustomID
		{
			[Cpp2IlInjected.Token(Token = "0x6007C14")]
			[Cpp2IlInjected.Address(RVA = "0x18BE4E0", Offset = "0x18BCEE0", VA = "0x1818BE4E0")]
			get
			{
				return GameCustomID + "_cfg";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700158B")]
		public bool HasGameCustomID
		{
			[Cpp2IlInjected.Token(Token = "0x6007C15")]
			[Cpp2IlInjected.Address(RVA = "0x18BE5C0", Offset = "0x18BCFC0", VA = "0x1818BE5C0")]
			get
			{
				return HasKeyChainValue("dev_cid");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700158C")]
		public bool HasGameloftIDCredentials
		{
			[Cpp2IlInjected.Token(Token = "0x6007C16")]
			[Cpp2IlInjected.Address(RVA = "0x18BE600", Offset = "0x18BD000", VA = "0x1818BE600")]
			get
			{
				bool flag = HasKeyChainValue("glid_email");
				if (!flag)
				{
					return flag;
				}
				return HasKeyChainValue("glid_pwd");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700158D")]
		public bool HasGameloftIDUnconfirmed
		{
			[Cpp2IlInjected.Token(Token = "0x6007C17")]
			[Cpp2IlInjected.Address(RVA = "0x18BE670", Offset = "0x18BD070", VA = "0x1818BE670")]
			get
			{
				if (HasKeyChainValue("glid_email") && HasKeyChainValue("glid_pwd"))
				{
					return !HasKeyChainValue("glid_link");
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700158E")]
		public bool HasGameloftID
		{
			[Cpp2IlInjected.Token(Token = "0x6007C18")]
			[Cpp2IlInjected.Address(RVA = "0x18BE710", Offset = "0x18BD110", VA = "0x1818BE710")]
			get
			{
				if (HasKeyChainValue("glid_email") && HasKeyChainValue("glid_pwd"))
				{
					return HasKeyChainValue("glid_link");
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700158F")]
		public string GameCustomID
		{
			[Cpp2IlInjected.Token(Token = "0x6007C19")]
			[Cpp2IlInjected.Address(RVA = "0x18BE530", Offset = "0x18BCF30", VA = "0x1818BE530")]
			get
			{
				//Discarded unreachable code: IL_001f
				string userId_ = DebugSettings.userId_;
				string prefix = default(string);
				return GetValueFor("dev_cid", userId_, "username", prefix);
			}
			[Cpp2IlInjected.Token(Token = "0x6007C1A")]
			[Cpp2IlInjected.Address(RVA = "0x18BEBB0", Offset = "0x18BD5B0", VA = "0x1818BEBB0")]
			set
			{
				SetKeyChainValue("dev_cid", value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001590")]
		public string RememberGameloftIDEmail
		{
			[Cpp2IlInjected.Token(Token = "0x6007C1B")]
			[Cpp2IlInjected.Address(RVA = "0x18BE7B0", Offset = "0x18BD1B0", VA = "0x1818BE7B0")]
			get
			{
				//Discarded unreachable code: IL_0038
				//IL_002c: Expected O, but got I4
				IKeyChain keyChain = KeyChain;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if ("glid_email" != null)
				{
					int num3 = 0;
					Security security = ProfileUtil.GetSecurity();
					byte[] bytes = Convert.FromBase64String((string)num);
					return security.DecryptToString(bytes);
				}
				int num4 = 0;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007C1C")]
			[Cpp2IlInjected.Address(RVA = "0x18BEC00", Offset = "0x18BD600", VA = "0x1818BEC00")]
			set
			{
				//Discarded unreachable code: IL_0020
				int num = 0;
				string value2 = Convert.ToBase64String(ProfileUtil.GetSecurity().Encrypt(value));
				SetKeyChainValue("glid_email", value2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001591")]
		public string RememberGameloftIDPassword
		{
			[Cpp2IlInjected.Token(Token = "0x6007C1D")]
			[Cpp2IlInjected.Address(RVA = "0x18BEA30", Offset = "0x18BD430", VA = "0x1818BEA30")]
			get
			{
				//Discarded unreachable code: IL_0038
				//IL_002c: Expected O, but got I4
				IKeyChain keyChain = KeyChain;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if ("glid_pwd" != null)
				{
					int num3 = 0;
					Security security = ProfileUtil.GetSecurity();
					byte[] bytes = Convert.FromBase64String((string)num);
					return security.DecryptToString(bytes);
				}
				int num4 = 0;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007C1E")]
			[Cpp2IlInjected.Address(RVA = "0x18BED20", Offset = "0x18BD720", VA = "0x1818BED20")]
			set
			{
				//Discarded unreachable code: IL_0020
				int num = 0;
				string value2 = Convert.ToBase64String(ProfileUtil.GetSecurity().Encrypt(value));
				SetKeyChainValue("glid_pwd", value2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001592")]
		public string RememberGameloftIDLink
		{
			[Cpp2IlInjected.Token(Token = "0x6007C1F")]
			[Cpp2IlInjected.Address(RVA = "0x18BE930", Offset = "0x18BD330", VA = "0x1818BE930")]
			get
			{
				IKeyChain keyChain = KeyChain;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				num += 344;
				throw new NullReferenceException();
			}
			[Cpp2IlInjected.Token(Token = "0x6007C20")]
			[Cpp2IlInjected.Address(RVA = "0x18BECD0", Offset = "0x18BD6D0", VA = "0x1818BECD0")]
			set
			{
				SetKeyChainValue("glid_link", value);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007C21")]
		[Cpp2IlInjected.Address(RVA = "0x18BE450", Offset = "0x18BCE50", VA = "0x1818BE450")]
		public CredentialProvider(DebugSettings debugSettings, IKeyChain keyChain)
		{
			DebugSettings = debugSettings;
			KeyChain = keyChain;
			bool flag = (_newGameCID = !HasKeyChainValue("dev_cid"));
		}

		[Cpp2IlInjected.Token(Token = "0x6007C22")]
		[Cpp2IlInjected.Address(RVA = "0x18BE0A0", Offset = "0x18BCAA0", VA = "0x1818BE0A0")]
		public Credential Get()
		{
			//IL_001a: Expected I4, but got I8
			Credential credential = new Credential();
			credential.username_ = "";
			credential.type_ = Credential.Types.Type.Anonymous;
			string text = (credential.username_ = ProtoPreconditions.CheckNotNull(GameCustomID, "value"));
			return credential;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C23")]
		[Cpp2IlInjected.Address(RVA = "0x18BE260", Offset = "0x18BCC60", VA = "0x1818BE260")]
		public void ResetGameID()
		{
			IKeyChain keyChain = KeyChain;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007C24")]
		[Cpp2IlInjected.Address(RVA = "0x18BE2C0", Offset = "0x18BCCC0", VA = "0x1818BE2C0")]
		public void ResetGameloftID()
		{
			IKeyChain keyChain = KeyChain;
			IKeyChain keyChain2 = KeyChain;
			IKeyChain keyChain3 = KeyChain;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6007C25")]
		[Cpp2IlInjected.Address(RVA = "0x18BE380", Offset = "0x18BCD80", VA = "0x1818BE380")]
		private void SetKeyChainValue(string key, string value)
		{
			//Discarded unreachable code: IL_001e
			IKeyChain keyChain = KeyChain;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			string text = keyChain.Get(key);
		}

		[Cpp2IlInjected.Token(Token = "0x6007C26")]
		[Cpp2IlInjected.Address(RVA = "0x18BE190", Offset = "0x18BCB90", VA = "0x1818BE190")]
		private bool HasKeyChainValue(string key)
		{
			//Discarded unreachable code: IL_001b
			//IL_001b: Expected I4, but got O
			IKeyChain keyChain = KeyChain;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			return (byte)(int)typeof(IKeyChain).TypeHandle != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C27")]
		[Cpp2IlInjected.Address(RVA = "0x18BDE80", Offset = "0x18BC880", VA = "0x1818BDE80")]
		private string GetValueFor(string KeychainKey, string debugDefault, string KeychainDeprecatedKey, string prefix = "")
		{
			//Discarded unreachable code: IL_004e
			string empty = string.Empty;
			if (empty != null)
			{
				if (empty == null)
				{
					IKeyChain keyChain = KeyChain;
					IKeyChain keyChain2 = KeyChain;
				}
				IKeyChain keyChain3 = KeyChain;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				if (empty == null)
				{
					Guid guid = Guid.NewGuid();
				}
			}
			SetKeyChainValue(KeychainKey, debugDefault);
			return debugDefault;
		}
	}
}
