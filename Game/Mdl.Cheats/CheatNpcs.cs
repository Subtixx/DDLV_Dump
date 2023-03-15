using Cpp2IlInjected;
using Mdl.Characters;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Cheats
{
	[Cpp2IlInjected.Token(Token = "0x2000842")]
	[CreateAssetMenu]
	public class CheatNpcs : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6002551")]
		[Cpp2IlInjected.Address(RVA = "0xA7DCF0", Offset = "0xA7C6F0", VA = "0x180A7DCF0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatNpcs.cs", 21)]
		public void ForceAllToSit()
		{
			//Discarded unreachable code: IL_0011
			SystemRoot.Instance.GetSystem<CharacterManager>().DebugForceAllBehaviour(Character.DebugForceBehaviourType.Sit);
		}

		[Cpp2IlInjected.Token(Token = "0x6002552")]
		[Cpp2IlInjected.Address(RVA = "0xA7DB40", Offset = "0xA7C540", VA = "0x180A7DB40")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatNpcs.cs", 27)]
		public void ForceAllResetFreetimeMotivation()
		{
			//Discarded unreachable code: IL_0010
			SystemRoot.Instance.GetSystem<CharacterManager>().DebugAllResetFreetimeMotivation();
		}

		[Cpp2IlInjected.Token(Token = "0x6002553")]
		[Cpp2IlInjected.Address(RVA = "0xA7DC10", Offset = "0xA7C610", VA = "0x180A7DC10")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatNpcs.cs", 34)]
		public void ForceAllToFish()
		{
			//Discarded unreachable code: IL_0011
			SystemRoot.Instance.GetSystem<CharacterManager>().DebugForceAllBehaviour(Character.DebugForceBehaviourType.Fish);
		}

		[Cpp2IlInjected.Token(Token = "0x6002554")]
		[Cpp2IlInjected.Address(RVA = "0xA7DDD0", Offset = "0xA7C7D0", VA = "0x180A7DDD0")]
		[CheatMethod("D:\\J\\workspace\\Incremental\\releases_1.3\\Assets\\Scripts\\Cheats\\CheatNpcs.cs", 41)]
		public void ResetToDefault()
		{
			//Discarded unreachable code: IL_0015
			CharacterManager system = SystemRoot.Instance.GetSystem<CharacterManager>();
			int behaviourType = 0;
			system.DebugForceAllBehaviour((Character.DebugForceBehaviourType)behaviourType);
		}

		[Cpp2IlInjected.Token(Token = "0x6002555")]
		[Cpp2IlInjected.Address(RVA = "0x837EA0", Offset = "0x8368A0", VA = "0x180837EA0")]
		public CheatNpcs()
		{
		}
	}
}
