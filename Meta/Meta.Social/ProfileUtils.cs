using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using glPlayFab;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000DAF")]
	public sealed class ProfileUtils
	{
		[Cpp2IlInjected.Token(Token = "0x600725A")]
		[Cpp2IlInjected.Address(RVA = "0x147A0A0", Offset = "0x1478AA0", VA = "0x18147A0A0")]
		[AsyncStateMachine(typeof(_003CUpdateUserInfoAsync_003Ed__0))]
		public static Task<UpdateUserInfo.Result> UpdateUserInfoAsync(ClientSession clientSession, UpdateUserInfo.Request request)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<UpdateUserInfo.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600725B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ProfileUtils()
		{
		}
	}
}
