using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006EA")]
	public interface IVantagePointSlotPosition
	{
		[Cpp2IlInjected.Token(Token = "0x6001EB9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Vector3 PickPosition(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6001EBA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Vector3 LookAtTarget(GameObject agent);
	}
}
