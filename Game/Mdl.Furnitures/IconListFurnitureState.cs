using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Grid;
using Gameloft.Common;
using Mdl.Grid;
using Mdl.Navigation;
using Meta.Grids;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Furnitures
{
	[Cpp2IlInjected.Token(Token = "0x200055E")]
	internal class IconListFurnitureState : GridObjectStateUser, IIndexState, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002155")]
		public FurnitureIconList iconList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002156")]
		public Renderer renderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002157")]
		[SerializeField]
		private AssetReferenceGameObject _itemSelectorPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002158")]
		private CancellationTokenSource cts = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x6001808")]
		[Cpp2IlInjected.Address(RVA = "0x11B2360", Offset = "0x11B0D60", VA = "0x1811B2360", Slot = "7")]
		protected override void InitWithGridObject(GridObject gridObject)
		{
			//Discarded unreachable code: IL_009c
			GridState state_ = gridObject.state_;
			if (state_ != null && state_.Index != null)
			{
				IndexGridData index = gridObject.state_.Index;
				int length = iconList.IconPairs.Length;
				if (index.currentIndex_ < length)
				{
					IndexGridData index2 = gridObject.state_.Index;
					FurnitureIconList furnitureIconList = iconList;
					GridState state_2 = gridObject.state_;
					FurnitureIconList.IconPair[] iconPairs = furnitureIconList.IconPairs;
					int currentIndex_ = state_2.Index.currentIndex_;
					CancellationTokenSource cancellationTokenSource = cts;
					currentIndex_ += 2;
					currentIndex_ += currentIndex_;
					CancellationToken token = cancellationTokenSource.Token;
					int num = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001809")]
		[Cpp2IlInjected.Address(RVA = "0x11B2600", Offset = "0x11B1000", VA = "0x1811B2600", Slot = "6")]
		protected override void OnDestroy()
		{
			base.OnDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x600180A")]
		[Cpp2IlInjected.Address(RVA = "0x11B2220", Offset = "0x11B0C20", VA = "0x1811B2220", Slot = "8")]
		[AsyncStateMachine(typeof(_003CChooseNewIndex_003Ed__6))]
		public Task<int> ChooseNewIndex(CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<int>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600180B")]
		[Cpp2IlInjected.Address(RVA = "0x11B2790", Offset = "0x11B1190", VA = "0x1811B2790")]
		public IconListFurnitureState()
		{
		}
	}
}
