using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000684")]
	internal class RestaurantStandingPositionList : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40026B0")]
		public List<Transform> standingPositions;

		[Cpp2IlInjected.Token(Token = "0x6001CEE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public RestaurantStandingPositionList()
		{
		}
	}
}
