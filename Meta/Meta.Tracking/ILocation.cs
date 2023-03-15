using Cpp2IlInjected;

namespace Meta.Tracking
{
	[Cpp2IlInjected.Token(Token = "0x2000A90")]
	public interface ILocation
	{
		[Cpp2IlInjected.Token(Token = "0x6005B81")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string GetMapLocation();

		[Cpp2IlInjected.Token(Token = "0x6005B82")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string GetLocation();
	}
}
