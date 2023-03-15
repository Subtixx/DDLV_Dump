using System;
using System.Threading;
using Cpp2IlInjected;
using Mdl.Systems;
using Meta.Online;
using TMPro;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	public class ClientInfo : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		[SerializeField]
		private TMP_Text clientInfoText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		[SerializeField]
		private string userIdLabel;

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		private LocalStorage localStorage
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4B")]
			[Cpp2IlInjected.Address(RVA = "0x1001DF0", Offset = "0x10007F0", VA = "0x181001DF0")]
			get
			{
				SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
				if ((object)_003CInstance_003Ek__BackingField != null)
				{
					Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
					if (metaClient != null)
					{
						return metaClient.LocalStorage;
					}
				}
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x1001B70", Offset = "0x1000570", VA = "0x181001B70")]
		public void Start()
		{
			//Discarded unreachable code: IL_0049
			if (localStorage != null)
			{
				UpdateInfoWithLocalStorage();
				return;
			}
			int num = 0;
			string _003CLastPlayFabId_003Ek__BackingField = ((GlobalStorageData)((BaseStorage<DataType>)(object)GlobalStorage.Instance).Data).LastPlayFabId;
			OnClientInfoUpdate(_003CLastPlayFabId_003Ek__BackingField);
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client.OnUserCredentialSetupCompletedCB value = OnUserCredentialSetupCompleted;
			metaClient.OnUserCredentialSetupCompleted += value;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x1001820", Offset = "0x1000220", VA = "0x181001820")]
		protected void OnDestroy()
		{
			//Discarded unreachable code: IL_0059
			if (this.localStorage != null)
			{
				LocalStorage localStorage = this.localStorage;
				LocalStorage.LocalStorageInfoChanged value = OnClientInfoUpdate;
				localStorage.OnLocalStorageInfoChanged -= value;
			}
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaClient != null)
			{
				Client metaClient = SystemRoot.Instance.MetaClient;
				Client.OnUserCredentialSetupCompletedCB value2 = OnUserCredentialSetupCompleted;
				metaClient.OnUserCredentialSetupCompleted -= value2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x1001A40", Offset = "0x1000440", VA = "0x181001A40")]
		private void OnUserCredentialSetupCompleted()
		{
			//Discarded unreachable code: IL_0026
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client.OnUserCredentialSetupCompletedCB value = OnUserCredentialSetupCompleted;
			metaClient.OnUserCredentialSetupCompleted -= value;
			UpdateInfoWithLocalStorage();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x1001CF0", Offset = "0x10006F0", VA = "0x181001CF0")]
		private void UpdateInfoWithLocalStorage()
		{
			//Discarded unreachable code: IL_0047
			if (this.localStorage != null)
			{
				string _003CPlayFabId_003Ek__BackingField = ((LocalStorageData)((BaseStorage<DataType>)(object)this.localStorage).Data).User.OnlineInfo.PlayFabId;
				OnClientInfoUpdate(_003CPlayFabId_003Ek__BackingField);
				LocalStorage localStorage = this.localStorage;
				LocalStorage.LocalStorageInfoChanged value = OnClientInfoUpdate;
				localStorage.OnLocalStorageInfoChanged += value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x1001710", Offset = "0x1000110", VA = "0x181001710")]
		private void OnClientInfoUpdate(string playFabId)
		{
			//Discarded unreachable code: IL_0029
			string playFabId2 = playFabId;
			SendOrPostCallback sendOrPostCallback = delegate
			{
				//Discarded unreachable code: IL_0084
				string text = playFabId2;
				ClientInfo clientInfo = this;
				if ("" != null)
				{
					clientInfo.clientInfoText.text = "";
					GameObject gameObject = clientInfoText.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
				else
				{
					TMP_Text tMP_Text = clientInfo.clientInfoText;
					string text2 = clientInfo.userIdLabel;
					string text3 = playFabId2;
					string text5 = (tMP_Text.text = text2 + text3);
					clientInfoText.gameObject.SetActive(value: true);
				}
			};
			object obj = ((ICloneable)playFabId).Clone();
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public ClientInfo()
		{
		}
	}
}
