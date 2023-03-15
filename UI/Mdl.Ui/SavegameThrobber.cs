using System.Threading;
using Cpp2IlInjected;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using Meta.Util;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000285")]
	public class SavegameThrobber : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000286")]
		private class ThrobberWritableContext : IWritableDisplayer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000B69")]
			private int refCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000B6A")]
			private ThrobberIcon throbber;

			[Cpp2IlInjected.Token(Token = "0x6001001")]
			[Cpp2IlInjected.Address(RVA = "0x1151E20", Offset = "0x1150820", VA = "0x181151E20")]
			public ThrobberWritableContext(ThrobberIcon throbber)
			{
				//IL_0016: Expected I4, but got I8
				this.throbber = throbber;
				refCount = 0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6001002")]
			[Cpp2IlInjected.Address(RVA = "0x1151D10", Offset = "0x1150710", VA = "0x181151D10", Slot = "4")]
			public void StartProgress()
			{
				//Discarded unreachable code: IL_0017
				if (refCount == 1)
				{
					SendOrPostCallback sendOrPostCallback = delegate
					{
						throbber?.Show();
					};
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6001003")]
			[Cpp2IlInjected.Address(RVA = "0x1151C30", Offset = "0x1150630", VA = "0x181151C30", Slot = "5")]
			public void EndProgress()
			{
				//Discarded unreachable code: IL_0017
				//IL_0009: Expected I4, but got I8
				refCount = 0;
				SendOrPostCallback sendOrPostCallback = delegate
				{
					throbber?.Hide();
				};
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B67")]
		[SerializeField]
		private ThrobberIcon throbber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B68")]
		private ThrobberWritableContext SaveThrobber;

		[Cpp2IlInjected.Token(Token = "0x6000FFD")]
		[Cpp2IlInjected.Address(RVA = "0x1257840", Offset = "0x1256240", VA = "0x181257840")]
		private void Start()
		{
			//Discarded unreachable code: IL_0066
			//IL_0010: Expected O, but got I4
			ThrobberIcon throbberIcon = throbber;
			int num = 0;
			if (throbberIcon != (Object)num)
			{
				SavegameManager saveGameManager = SystemRoot.Instance._saveGameManager;
				if ((object)saveGameManager != null && saveGameManager.Config.IsDisplayingThrobber)
				{
					ThrobberWritableContext throbberWritableContext = (SaveThrobber = new ThrobberWritableContext(throbber));
					SaveThrobber.EndProgress();
					Client.StartUpHandler value = RegisterSaveThrobber;
					Client client = default(Client);
					client.OnStartUp += value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FFE")]
		[Cpp2IlInjected.Address(RVA = "0x1257660", Offset = "0x1256060", VA = "0x181257660")]
		private void RegisterSaveThrobber(Profile profile, CancellationToken ct)
		{
			//Discarded unreachable code: IL_004f
			ThrobberWritableContext saveThrobber = SaveThrobber;
			if ((object)typeof(SystemRoot).TypeHandle == null)
			{
				LocalProfileHolder _003CLocalProfileHolder_003Ek__BackingField = SystemRoot.Instance.MetaClient.LocalProfileHolder;
				ThrobberWritableContext throbberWritableContext = (ThrobberWritableContext)(_003CLocalProfileHolder_003Ek__BackingField.ProgressDisplayer = SaveThrobber);
			}
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client.StartUpHandler value = RegisterSaveThrobber;
			metaClient.OnStartUp -= value;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FFF")]
		[Cpp2IlInjected.Address(RVA = "0x1257410", Offset = "0x1255E10", VA = "0x181257410")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_005b
			ThrobberWritableContext saveThrobber = SaveThrobber;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.LocalProfileHolder != 0)
				{
					LocalProfileHolder _003CLocalProfileHolder_003Ek__BackingField = SystemRoot.Instance.MetaClient.LocalProfileHolder;
					Client metaClient2 = SystemRoot.Instance.MetaClient;
					Client.StartUpHandler value = RegisterSaveThrobber;
					metaClient2.OnStartUp -= value;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001000")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public SavegameThrobber()
		{
		}
	}
}
