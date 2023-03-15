using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine.Scripting;

namespace Gameloft.Tracking.Device
{
	[StructLayout(LayoutKind.Sequential)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class GpuInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private string processor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private uint ram;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private bool state;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return name;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[Preserve]
		private GpuInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x402DD10", Offset = "0x402C710", VA = "0x18402DD10")]
		[AsyncStateMachine(typeof(_003CCollectAsync_003Ed__11))]
		public static Task<GpuInfo[]> CollectAsync()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<GpuInfo[]>)(object)result;
		}
	}
}
