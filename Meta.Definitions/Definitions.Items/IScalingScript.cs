using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000695")]
	public interface IScalingScript
	{
		[Cpp2IlInjected.Token(Token = "0x6004AE7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float GetScale(float input);
	}
}
