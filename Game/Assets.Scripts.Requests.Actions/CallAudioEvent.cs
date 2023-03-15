using Cpp2IlInjected;
using Mdl.Audio;
using Mdl.Systems;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[Category("Mdl")]
	[Icon("Dialogue", false, "")]
	public class CallAudioEvent : MdlActionTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public BBParameter<string> eventName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public BBParameter<bool> global;

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x16472C0", Offset = "0x1645CC0", VA = "0x1816472C0", Slot = "13")]
		protected override void OnExecute()
		{
			//Discarded unreachable code: IL_0059
			if (((BBParameter<T>)(object)global).value == null)
			{
				AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
				string value = (string)((BBParameter<T>)(object)eventName).value;
				system.TriggerAudioEvent(value);
			}
			string value2 = (string)((BBParameter<T>)(object)eventName).value;
			GameObject gameObject = SystemRoot.Instance.GetSystem<AudioManager>().gameObject;
			uint num = AkSoundEngine.PostEvent(value2, gameObject);
			EndAction(success: true);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x8CB450", Offset = "0x8C9E50", VA = "0x1808CB450")]
		public CallAudioEvent()
		{
		}
	}
}
