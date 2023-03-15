using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BE1")]
	internal class PlantSeedActionSeedChoice : IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400422D")]
		public Item ChosenSeed;

		[Cpp2IlInjected.Token(Token = "0x6003667")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PlantSeedActionSeedChoice()
		{
		}
	}
}
