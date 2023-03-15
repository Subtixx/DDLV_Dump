using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Util;
using Google.Protobuf.Collections;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Grids;
using UnityEngine.AddressableAssets;

namespace Mdl.Furnitures
{
	[Cpp2IlInjected.Token(Token = "0x200055D")]
	public class FurnitureStorage : GridObjectStateUser, IPlayerTaskData, IDefaultGridStateProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002154")]
		public AssetReference menuToOpen;

		[Cpp2IlInjected.Token(Token = "0x17000335")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6001802")]
			[Cpp2IlInjected.Address(RVA = "0x8BC3D0", Offset = "0x8BADD0", VA = "0x1808BC3D0")]
			get
			{
				//Discarded unreachable code: IL_0073
				GridObjectScript gridObjectScript = base.GridObjectScript;
				if ((object)gridObjectScript != null)
				{
					GridObject _003CGridObject_003Ek__BackingField = gridObjectScript.GridObject;
					if (_003CGridObject_003Ek__BackingField != null)
					{
						GridState state_ = _003CGridObject_003Ek__BackingField.state_;
						if (state_ != null && state_.Storage != null)
						{
							ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
							GridObjectScript gridObjectScript2 = base.GridObjectScript;
							MapField<uint, ContainerInventory> containerInventories_ = player_.containerInventories_;
							StorageGridData storage = gridObjectScript2.GridObject.state_.Storage;
							bool flag = default(bool);
							if (!flag)
							{
								return true;
							}
							int num = default(int);
							return num == 0;
						}
					}
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001803")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001804")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		public void InitFromGridState(GridState gridState)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001805")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "9")]
		public bool ForceGridState(ref GridState gridState, ITransactionContext context)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001806")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "10")]
		public void ChangeGridState(GridState gridState, ITransactionContext context)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001807")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public FurnitureStorage()
		{
		}
	}
}
