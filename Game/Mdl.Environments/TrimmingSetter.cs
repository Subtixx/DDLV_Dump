using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000698")]
	public abstract class TrimmingSetter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400270E")]
		[SerializeField]
		private Renderer _renderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400270F")]
		private TrimmingItemData trimmingItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002710")]
		private AsyncOperationHandle<Material> trimmingHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002711")]
		private AsyncOperationHandle<GameObject> accentHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002712")]
		private CancellationTokenSource cts = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002713")]
		private GameObject accentPrefabInstance;

		[Cpp2IlInjected.Token(Token = "0x17000413")]
		public Item TrimmingItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001D33")]
			[Cpp2IlInjected.Address(RVA = "0x13E0700", Offset = "0x13DF100", VA = "0x1813E0700")]
			get
			{
				return trimmingItemData?.Item ?? Item.Invalid;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D34")]
			[Cpp2IlInjected.Address(RVA = "0x13E0780", Offset = "0x13DF180", VA = "0x1813E0780")]
			set
			{
				//Discarded unreachable code: IL_00ce
				//IL_002b: Expected O, but got I4
				//IL_0042: Expected O, but got I8
				//IL_0051: Expected O, but got I4
				//IL_007a: Expected O, but got I4
				TrimmingItemData trimmingItemData = this.trimmingItemData;
				if (trimmingItemData != null)
				{
					Item item = trimmingItemData.Item;
				}
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
				GameObject gameObject = accentPrefabInstance;
				int num = 0;
				if (gameObject != (Object)num)
				{
					Object.Destroy(accentPrefabInstance);
					accentPrefabInstance = (GameObject)0;
				}
				int num2 = 0;
				TrimmingItemData trimmingItemData2 = (this.trimmingItemData = ItemDatabase.Instance.GetItemData<TrimmingItemData>((Item)num2));
				if ((long)this.trimmingItemData == 0)
				{
					return;
				}
				Renderer renderer = _renderer;
				int num3 = 0;
				if (renderer != (Object)num3)
				{
					TrimmingItemData trimmingItemData3 = this.trimmingItemData;
					CancellationToken token = cts.Token;
					int num4 = 0;
					Task task = default(Task);
					task.FireAndForgetTask();
					string accentPrefabAddress_ = this.trimmingItemData.accentPrefabAddress_;
					if (task == null)
					{
						TrimmingItemData trimmingItemData4 = this.trimmingItemData;
						CancellationToken token2 = cts.Token;
						int num5 = 0;
						Task asyncTask = default(Task);
						asyncTask.FireAndForgetTask();
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000414")]
		public abstract TrimmingItemType HandledTrimmingItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6001D35")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D36")]
		[Cpp2IlInjected.Address(RVA = "0x13E0330", Offset = "0x13DED30", VA = "0x1813E0330")]
		private void OnDestroy()
		{
			bool flag = default(bool);
			if (flag)
			{
				Addressables.Release<Material>((AsyncOperationHandle<>)trimmingHandle);
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				Addressables.Release<GameObject>((AsyncOperationHandle<>)accentHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D37")]
		[Cpp2IlInjected.Address(RVA = "0x13E05D0", Offset = "0x13DEFD0", VA = "0x1813E05D0")]
		[AsyncStateMachine(typeof(_003CSetTrimmingMaterial_003Ed__12))]
		private Task SetTrimmingMaterial(string materialAddress, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D38")]
		[Cpp2IlInjected.Address(RVA = "0x13E04A0", Offset = "0x13DEEA0", VA = "0x1813E04A0")]
		[AsyncStateMachine(typeof(_003CSetAccentPrefab_003Ed__13))]
		private Task SetAccentPrefab(string accentPrefabAddress, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D39")]
		[Cpp2IlInjected.Address(RVA = "0x13E0070", Offset = "0x13DEA70", VA = "0x1813E0070")]
		protected TrimmingSetter()
		{
		}
	}
}
