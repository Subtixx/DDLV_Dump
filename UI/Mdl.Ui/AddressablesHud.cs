using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200079C")]
	public class AddressablesHud : InfoGizmo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002C85")]
		private IAddressableDownloadEvent AddressablesDownload;

		[Cpp2IlInjected.Token(Token = "0x60030AC")]
		[Cpp2IlInjected.Address(RVA = "0x87D030", Offset = "0x87BA30", VA = "0x18087D030", Slot = "11")]
		public override void Init(GameObject target, bool followTarget = false, [System.Runtime.InteropServices.Optional] CancellationToken? ct, params object[] parameters)
		{
			//Discarded unreachable code: IL_0047
			int num = 0;
			CancellationToken? cancellationToken = _cancellationToken;
			bool flag = default(bool);
			if (!flag)
			{
				Hide();
			}
			if ((object)typeof(IAddressableDownloadEvent).TypeHandle != null && (object)typeof(IAddressableDownloadEvent).TypeHandle != null)
			{
				AddressablesDownload = (IAddressableDownloadEvent)typeof(IAddressableDownloadEvent).TypeHandle;
				IAddressableDownloadEvent addressablesDownload = AddressablesDownload;
				AddressableDownloadEvent addressableDownloadEvent = AddressableEvent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030AD")]
		[Cpp2IlInjected.Address(RVA = "0x87D1D0", Offset = "0x87BBD0", VA = "0x18087D1D0")]
		private void OnDestroy()
		{
			if (AddressablesDownload != null)
			{
				AddressableDownloadEvent addressableDownloadEvent = AddressableEvent;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030AE")]
		[Cpp2IlInjected.Address(RVA = "0x87CF30", Offset = "0x87B930", VA = "0x18087CF30")]
		private void AddressableEvent(MdlAddressables.DownloadEvent eventType, float value = 0f)
		{
			//Discarded unreachable code: IL_001b
			string text = default(string);
			Debug.Log("AddressableEvent " + " value " + " value " + text);
		}

		[Cpp2IlInjected.Token(Token = "0x60030AF")]
		[Cpp2IlInjected.Address(RVA = "0x87D270", Offset = "0x87BC70", VA = "0x18087D270")]
		public AddressablesHud()
		{
		}
	}
}
