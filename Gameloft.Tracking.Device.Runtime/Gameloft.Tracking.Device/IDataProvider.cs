using Cpp2IlInjected;

namespace Gameloft.Tracking.Device
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface IDataProvider<T> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		T GetData();
	}
}
