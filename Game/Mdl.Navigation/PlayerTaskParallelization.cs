using Cpp2IlInjected;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C79")]
	public enum PlayerTaskParallelization
	{
		[Cpp2IlInjected.Token(Token = "0x40045B0")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40045B1")]
		MovementAndFacing,
		[Cpp2IlInjected.Token(Token = "0x40045B2")]
		Facing,
		[Cpp2IlInjected.Token(Token = "0x40045B3")]
		Everything,
		[Cpp2IlInjected.Token(Token = "0x40045B4")]
		EverythingExceptFacing
	}
}
