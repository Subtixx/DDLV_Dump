using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Systems;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AddressableAssets;

namespace Assets.Scripts.Requests
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[Category("Mdl")]
	[Description("Play a Cutscene inside a dialogue")]
	public class PlayCutscene : MdlActionTaskAsync
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public AssetReference reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public BBParameter<string> CutsceneId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public BBParameter<bool> CannotBeSkipped;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public BBParameter<bool> SkipCutsceneAudio;

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x14B8F40", Offset = "0x14B7940", VA = "0x1814B8F40", Slot = "18")]
		[AsyncStateMachine(typeof(_003CDoActionAsync_003Ed__4))]
		protected override System.Threading.Tasks.Task DoActionAsync()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.Threading.Tasks.Task result = default(System.Threading.Tasks.Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x14B8BE0", Offset = "0x14B75E0", VA = "0x1814B8BE0", Slot = "19")]
		protected override void BeforeEndAction(bool success)
		{
			//Discarded unreachable code: IL_004c
			if ((long)reference == 0)
			{
				CutsceneSystem system = SystemRoot.Instance.GetSystem<CutsceneSystem>();
				if ((object)system != null)
				{
					string value = (string)((BBParameter<T>)(object)CutsceneId).value;
					system.RemoveCutscene(value);
				}
			}
			else
			{
				CutsceneSystem system2 = SystemRoot.Instance.GetSystem<CutsceneSystem>();
				while ((object)system2 == null)
				{
				}
				AssetReference assetReference = reference;
				system2.RemoveCutscene(assetReference);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public PlayCutscene()
		{
		}
	}
}
