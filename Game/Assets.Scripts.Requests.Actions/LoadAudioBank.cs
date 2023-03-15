using Cpp2IlInjected;
using Mdl.Audio;
using Mdl.Systems;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[Category("Mdl")]
	[Icon("Dialogue", false, "")]
	public class LoadAudioBank : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		public BBParameter<string> bankName;

		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(RVA = "0xBB5230", Offset = "0xBB3C30", VA = "0x180BB5230", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0026
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			string value = (string)((BBParameter<T>)(object)bankName).value;
			system.LoadBankWithTag(value);
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0xA3D130", Offset = "0xA3BB30", VA = "0x180A3D130")]
		public LoadAudioBank()
		{
		}
	}
}
