using Cpp2IlInjected;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003D9")]
	public abstract class InputTrigger
	{
		[Cpp2IlInjected.Token(Token = "0x600109A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool Update(float deltaTime, bool currentIsActuated, bool previousIsActuated);

		[Cpp2IlInjected.Token(Token = "0x600109B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		protected InputTrigger()
		{
		}
	}
}
