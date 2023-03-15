using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Items;
using UnityEngine;

namespace Mdl.Environments.PointsOfInterest
{
	[Cpp2IlInjected.Token(Token = "0x20006CC")]
	public interface IPointOfInterest
	{
		[Cpp2IlInjected.Token(Token = "0x17000446")]
		bool Destroyed
		{
			[Cpp2IlInjected.Token(Token = "0x6001E2D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000447")]
		Vector3 Position
		{
			[Cpp2IlInjected.Token(Token = "0x6001E2E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000448")]
		int Occupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001E2F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000449")]
		int MaxOccupants
		{
			[Cpp2IlInjected.Token(Token = "0x6001E30")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700044A")]
		ItemScript ItemScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001E31")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700044B")]
		float RemainingTime
		{
			[Cpp2IlInjected.Token(Token = "0x6001E32")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6001E33")]
		[Cpp2IlInjected.Address(Slot = "6")]
		float InterestWeight(GameObject agent, GameObject avatar, PointOfInterestActionConfig config);

		[Cpp2IlInjected.Token(Token = "0x6001E34")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool CanInterruptAction(GameObject interruptee, GameObject interruptor);

		[Cpp2IlInjected.Token(Token = "0x6001E35")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CanVisit(GameObject agent, PointOfInterestActionConfig config);

		[Cpp2IlInjected.Token(Token = "0x6001E36")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool ArrivedAtPoint(GameObject agent);

		[Cpp2IlInjected.Token(Token = "0x6001E37")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task Visit(GameObject agent, PointOfInterestActionConfig config, float duration, float speed, CancellationToken ct);
	}
}
