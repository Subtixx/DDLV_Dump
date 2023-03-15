using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000848")]
	internal interface IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x6003498")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam);
	}
}
