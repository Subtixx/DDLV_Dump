using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Activities;
using Mdl.Avatar;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000BE2")]
	internal class PlantSeedAction : AnimatedPlayerAction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400422E")]
		[SerializeField]
		private GameObject _gardeningResultInfoGizmoPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400422F")]
		[SerializeField]
		private AssetReferenceGameObject _itemSelectorPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4004230")]
		[SerializeField]
		private AssetReferenceSprite _correctVillageAreaIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4004231")]
		[SerializeField]
		private float cameraTransitionDuration = 0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4004232")]
		[SerializeField]
		private PlantSeedHoldBehaviour holdBehaviour;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4004233")]
		[SerializeField]
		private AssetReferenceGameObject plantSeedVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4004234")]
		public AK.Wwise.Event plantSeedSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4004235")]
		public AK.Wwise.Event noSeedSFX;

		[Cpp2IlInjected.Token(Token = "0x1700074B")]
		private static Item LastSeedSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6003668")]
			[Cpp2IlInjected.Address(RVA = "0xF13090", Offset = "0xF11A90", VA = "0x180F13090")]
			[CompilerGenerated]
			get
			{
				return _003CLastSeedSelected_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003669")]
			[Cpp2IlInjected.Address(RVA = "0xF130D0", Offset = "0xF11AD0", VA = "0x180F130D0")]
			[CompilerGenerated]
			set
			{
				//IL_000b: Expected O, but got I4
				_003CLastSeedSelected_003Ek__BackingField = (Item)value.ItemID;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600366A")]
		[Cpp2IlInjected.Address(RVA = "0xF12C70", Offset = "0xF11670", VA = "0x180F12C70", Slot = "8")]
		[AsyncStateMachine(typeof(_003CCanExecuteAction_003Ed__12))]
		public override Task<bool> CanExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600366B")]
		[Cpp2IlInjected.Address(RVA = "0xF12F30", Offset = "0xF11930", VA = "0x180F12F30", Slot = "5")]
		[AsyncStateMachine(typeof(_003CExecuteAction_003Ed__13))]
		public override Task ExecuteAction(PlayerAvatar avatar, PlayerTask task, CancellationToken ct)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600366C")]
		[Cpp2IlInjected.Address(RVA = "0xF12DB0", Offset = "0xF117B0", VA = "0x180F12DB0")]
		[AsyncStateMachine(typeof(_003CChooseSeedToPlant_003Ed__14))]
		private Task<Item> ChooseSeedToPlant(GardeningSlot gardeningSlot, PlayerTask task, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Item>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x600366D")]
		[Cpp2IlInjected.Address(RVA = "0xF13080", Offset = "0xF11A80", VA = "0x180F13080")]
		public PlantSeedAction()
		{
		}
	}
}
