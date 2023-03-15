using Cpp2IlInjected;
using Mdl.Systems;
using Meta;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000790")]
	public class OpenHomeStorageMenuPlayerTaskData : OpenMenuPlayerTaskData
	{
		[Cpp2IlInjected.Token(Token = "0x6002198")]
		[Cpp2IlInjected.Address(RVA = "0xF05B70", Offset = "0xF04570", VA = "0x180F05B70", Slot = "4")]
		public override object[] GetParameters()
		{
			//Discarded unreachable code: IL_002e
			object[] array;
			ContainerInventory homeStorage;
			do
			{
				array = new object[1];
				homeStorage = SystemRoot.Instance.MetaClient.profile.HomeStorage;
			}
			while (homeStorage != null && homeStorage == null);
			array[0] = homeStorage;
			return array;
		}

		[Cpp2IlInjected.Token(Token = "0x6002199")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public OpenHomeStorageMenuPlayerTaskData()
		{
		}
	}
}
