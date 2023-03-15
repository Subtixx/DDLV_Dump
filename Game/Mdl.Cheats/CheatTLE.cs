using System.Threading.Tasks;
using CloudScripts;
using Cpp2IlInjected;
using glPlayFab;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000845")]
	[CreateAssetMenu]
	public class CheatTLE : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700055A")]
		private Client client
		{
			[Cpp2IlInjected.Token(Token = "0x600257C")]
			[Cpp2IlInjected.Address(RVA = "0xA7F930", Offset = "0xA7E330", VA = "0x180A7F930")]
			get
			{
				//Discarded unreachable code: IL_000b
				return SystemRoot.Instance.MetaClient;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055B")]
		private Profile profile
		{
			[Cpp2IlInjected.Token(Token = "0x600257D")]
			[Cpp2IlInjected.Address(RVA = "0xA7F9E0", Offset = "0xA7E3E0", VA = "0x180A7F9E0")]
			get
			{
				//Discarded unreachable code: IL_0010
				return SystemRoot.Instance.MetaClient.profile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700055C")]
		[CheatProperty("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatTLE.cs", 17)]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4002E1A")]
		public PlayFabTLEContext.Type TLEType
		{
			[Cpp2IlInjected.Token(Token = "0x600257E")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600257F")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6002580")]
		[Cpp2IlInjected.Address(RVA = "0xA7F850", Offset = "0xA7E250", VA = "0x180A7F850")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatTLE.cs", 20)]
		public void ResetSelectedEventProgression()
		{
			//Discarded unreachable code: IL_002b
			OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
			if (metaOnlineClient != null)
			{
				DisneyCloudScript playfabScriptExecutor = metaOnlineClient.PlayfabScriptExecutor;
				if (playfabScriptExecutor != null)
				{
					PlayFabTLEContext.Type type = TLEType;
					Task<bool> task = (Task<bool>)(object)playfabScriptExecutor.CheatTLEResetProgression(type);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002581")]
		[Cpp2IlInjected.Address(RVA = "0xA7F780", Offset = "0xA7E180", VA = "0x180A7F780")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatTLE.cs", 26)]
		public void ResetAllEventsProgression()
		{
			//Discarded unreachable code: IL_0023
			OnlineClient metaOnlineClient = SystemRoot.Instance.MetaOnlineClient;
			if (metaOnlineClient != null)
			{
				DisneyCloudScript playfabScriptExecutor = metaOnlineClient.PlayfabScriptExecutor;
				if (playfabScriptExecutor != null)
				{
					Task<bool> task = (Task<bool>)(object)playfabScriptExecutor.CheatTLEResetProgression();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002582")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public CheatTLE()
		{
		}
	}
}
