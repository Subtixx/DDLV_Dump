using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Utils;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public abstract class MdlActionTaskAsync : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private Task task;

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract Task DoActionAsync();

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "19")]
		protected virtual void BeforeEndAction(bool success)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xBC0030", Offset = "0xBBEA30", VA = "0x180BC0030", Slot = "13")]
		protected override void OnExecute()
		{
			int success = 0;
			BeforeEndAction((byte)success != 0);
			Task task = (this.task = DoActionAsync());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xBC0070", Offset = "0xBBEA70", VA = "0x180BC0070", Slot = "14")]
		protected override void OnUpdate()
		{
			//Discarded unreachable code: IL_0056
			int success = 0;
			BeforeEndAction((byte)success != 0);
			if (!task.IsCompletedSuccessfully())
			{
				if (task.IsCanceled || task.IsFaulted)
				{
					int success2 = 0;
					BeforeEndAction((byte)success2 != 0);
					int success3 = 0;
					EndAction((byte)success3 != 0);
				}
			}
			else
			{
				BeforeEndAction(success: true);
				EndAction(success: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xBBFFF0", Offset = "0xBBE9F0", VA = "0x180BBFFF0")]
		private void ApplyEnd(bool success)
		{
			BeforeEndAction(success);
			EndAction(success);
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xA3D130", Offset = "0xA3BB30", VA = "0x180A3D130")]
		protected MdlActionTaskAsync()
		{
		}
	}
}
