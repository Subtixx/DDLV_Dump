using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C20")]
	public interface ICameraBoundary
	{
		[Cpp2IlInjected.Token(Token = "0x17000757")]
		bool IsConstraint
		{
			[Cpp2IlInjected.Token(Token = "0x6003731")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000758")]
		string DebugName
		{
			[Cpp2IlInjected.Token(Token = "0x6003732")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600372F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool IsIn(Vector3 point);

		[Cpp2IlInjected.Token(Token = "0x6003730")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Vector3 ClosestPoint(Vector3 point);
	}
}
