using Cpp2IlInjected;
using glPlayFab.Disney;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	public interface IClientLiveopsConfig<T> : IFetchable, ITimeLimited where T : IOnlineLiveopsConfig
	{
		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		T ToServerConfig(string onlineId);
	}
}
