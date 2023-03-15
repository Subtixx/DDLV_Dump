using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Items;
using Mdl.Systems;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B7A")]
	public class LootBoxObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003FDA")]
		private CancellationTokenSource infoGizmoCTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003FDB")]
		private CancellationToken ct;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003FDC")]
		[SerializeField]
		private GameObject markerOffline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003FDD")]
		[SerializeField]
		private GameObject markerAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003FDE")]
		private bool hasMarker;

		[Cpp2IlInjected.Token(Token = "0x6003525")]
		[Cpp2IlInjected.Address(RVA = "0xBBCB80", Offset = "0xBBB580", VA = "0x180BBCB80")]
		private void Start()
		{
			//Discarded unreachable code: IL_004f
			OnlineClient _003COnlineClient_003Ek__BackingField = SystemRoot.Instance.MetaClient.OnlineClient;
			OnlineClient.ConnectionModeChanged value = ConnectionModeChangedCB;
			_003COnlineClient_003Ek__BackingField.OnConnectionModeChanged += value;
			OnlineClient _003COnlineClient_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.OnlineClient;
			OnlineClient.OnlineConnectionChanged value2 = OnlineConnectionChangedCB;
			_003COnlineClient_003Ek__BackingField2.OnOnlineConnectionChanged += value2;
			ToggleOfflineGizmo();
		}

		[Cpp2IlInjected.Token(Token = "0x6003526")]
		[Cpp2IlInjected.Address(RVA = "0xBBC720", Offset = "0xBBB120", VA = "0x180BBC720")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_006d
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.OnlineClient != 0)
				{
					OnlineClient _003COnlineClient_003Ek__BackingField = SystemRoot.Instance.MetaClient.OnlineClient;
					OnlineClient.ConnectionModeChanged value = ConnectionModeChangedCB;
					_003COnlineClient_003Ek__BackingField.OnConnectionModeChanged -= value;
					OnlineClient _003COnlineClient_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.OnlineClient;
					OnlineClient.OnlineConnectionChanged value2 = OnlineConnectionChangedCB;
					_003COnlineClient_003Ek__BackingField2.OnOnlineConnectionChanged -= value2;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003527")]
		[Cpp2IlInjected.Address(RVA = "0xBBC6C0", Offset = "0xBBB0C0", VA = "0x180BBC6C0")]
		private void ConnectionModeChangedCB(OnlineClient.OnlineStatus currentOnlineStatus, CancellationToken ct)
		{
			ToggleOfflineGizmo();
		}

		[Cpp2IlInjected.Token(Token = "0x6003528")]
		[Cpp2IlInjected.Address(RVA = "0xBBC6C0", Offset = "0xBBB0C0", VA = "0x180BBC6C0")]
		private void OnlineConnectionChangedCB(Profile profile, bool isLoggedIn, CancellationToken ct)
		{
			ToggleOfflineGizmo();
		}

		[Cpp2IlInjected.Token(Token = "0x6003529")]
		[Cpp2IlInjected.Address(RVA = "0xBBCD70", Offset = "0xBBB770", VA = "0x180BBCD70")]
		private void ToggleOfflineGizmo()
		{
			//Discarded unreachable code: IL_006a
			//IL_0010: Expected O, but got I4
			//IL_0068: Expected O, but got I8
			ItemScript componentInChildren = GetComponentInChildren<ItemScript>();
			int num = 0;
			if (!(componentInChildren != (Object)num))
			{
				return;
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item = componentInChildren.Item;
			IIsOnlineOnly isOnlineOnly = default(IIsOnlineOnly);
			Client client = default(Client);
			if (isOnlineOnly != null && isOnlineOnly != null && client.OnlineClient.IsFullOnline)
			{
				CancellationTokenSource cancellationTokenSource = infoGizmoCTS;
				hasMarker = false;
				if (cancellationTokenSource != null)
				{
					cancellationTokenSource.Cancel();
					infoGizmoCTS.Dispose();
					infoGizmoCTS = (CancellationTokenSource)0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600352A")]
		[Cpp2IlInjected.Address(RVA = "0xBBC9A0", Offset = "0xBBB3A0", VA = "0x180BBC9A0")]
		private void ShowFlag()
		{
			//Discarded unreachable code: IL_0048
			while (!hasMarker && (long)infoGizmoCTS == 0)
			{
				hasMarker = true;
				CancellationTokenSource cancellationTokenSource = (infoGizmoCTS = new CancellationTokenSource());
				CancellationToken token = infoGizmoCTS.Token;
				object[] array = new object[1];
				if (array != null)
				{
					array[0] = this;
					break;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600352B")]
		[Cpp2IlInjected.Address(RVA = "0xBBC6D0", Offset = "0xBBB0D0", VA = "0x180BBC6D0")]
		public void Dispose()
		{
			//Discarded unreachable code: IL_000c
			hasMarker = false;
			if ((object)this == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600352C")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public LootBoxObject()
		{
		}
	}
}
