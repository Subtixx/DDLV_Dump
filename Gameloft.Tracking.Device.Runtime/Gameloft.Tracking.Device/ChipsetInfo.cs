using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Device
{
	[StructLayout(LayoutKind.Sequential)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class ChipsetInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private string model;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private string manufacturer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private string serial;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string Model
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get
			{
				return model;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string Manufacturer
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return manufacturer;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x402B890", Offset = "0x402A290", VA = "0x18402B890")]
		[AsyncStateMachine(typeof(_003CCollectAsync_003Ed__6))]
		public static Task<ChipsetInfo> CollectAsync()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<ChipsetInfo>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ChipsetInfo()
		{
		}
	}
}
