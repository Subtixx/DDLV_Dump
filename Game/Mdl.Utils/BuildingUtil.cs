using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200071C")]
	public static class BuildingUtil
	{
		[Cpp2IlInjected.Token(Token = "0x200071D")]
		public enum UnlockCheckType
		{
			[Cpp2IlInjected.Token(Token = "0x4002952")]
			Building,
			[Cpp2IlInjected.Token(Token = "0x4002953")]
			Character,
			[Cpp2IlInjected.Token(Token = "0x4002954")]
			Activity
		}

		[Cpp2IlInjected.Token(Token = "0x6001F90")]
		[Cpp2IlInjected.Address(RVA = "0x1645200", Offset = "0x1643C00", VA = "0x181645200")]
		[AsyncStateMachine(typeof(_003CCheckUnlock_003Ed__1))]
		public static Task<bool> CheckUnlock(IBuildingUnlockable building, CancellationToken ct, UnlockCheckType unlockCheckType = UnlockCheckType.Building, bool promptUnlock = true)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}
	}
}
