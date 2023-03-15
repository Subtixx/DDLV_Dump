using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200073E")]
	internal class DebugNavPath : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600203F")]
		[Cpp2IlInjected.Address(RVA = "0x161B420", Offset = "0x1619E20", VA = "0x18161B420")]
		private void Update()
		{
			//Discarded unreachable code: IL_0022
			NavMeshAgent component = GetComponent<NavMeshAgent>();
			if ((bool)component && component.hasPath)
			{
				NavMeshPath path = component.path;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002040")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugNavPath()
		{
		}
	}
}
