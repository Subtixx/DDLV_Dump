using System;
using Cpp2IlInjected;

namespace Mdl.Graphic
{
	[Cpp2IlInjected.Token(Token = "0x20004B3")]
	public class DOFScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001D71")]
		public readonly DOFDistance previous;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4001D72")]
		private bool forced;

		[Cpp2IlInjected.Token(Token = "0x60014DE")]
		[Cpp2IlInjected.Address(RVA = "0x11144E0", Offset = "0x1112EE0", VA = "0x1811144E0")]
		public DOFScope(DOFDistance profile, bool force = false)
		{
			//Discarded unreachable code: IL_003a
			forced = force;
			DOFDistance dOFDistance = (previous = PostProcessManager.Instance.currentDOF);
			PostProcessManager instance = PostProcessManager.Instance;
			if (forced)
			{
				PostProcessManager.Instance.forced = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014DF")]
		[Cpp2IlInjected.Address(RVA = "0x1114460", Offset = "0x1112E60", VA = "0x181114460", Slot = "4")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_0029
			if (forced)
			{
				PostProcessManager.Instance.forced = false;
			}
			PostProcessManager instance = PostProcessManager.Instance;
			DOFDistance dof = previous;
			instance.SetDof(dof);
		}
	}
}
