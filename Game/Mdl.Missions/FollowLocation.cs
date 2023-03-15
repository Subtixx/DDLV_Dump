using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000236")]
	public class FollowLocation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400132B")]
		public string Name;

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x14614E0", Offset = "0x145FEE0", VA = "0x1814614E0")]
		private void Awake()
		{
			//Discarded unreachable code: IL_001b
			MissionManager system = SystemRoot.Instance.GetSystem<MissionManager>();
			string text = Name;
			system.AddFollowLocation(text, this);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FollowLocation()
		{
		}
	}
}
