using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Activities;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002F1")]
	public class CollectionMemoryShardsView : ItemSlot
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000E4E")]
		private bool _isCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4000E4F")]
		private int _bits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000E50")]
		[SerializeField]
		private Image _shardsImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000E51")]
		[SerializeField]
		private CollectionTooltipMemoryShards _shardTooltip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000E52")]
		[SerializeField]
		private MemoryShardMaskData _noMaskMemoryShardMaskData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000E53")]
		private MemoryShardItemData _memoryShardItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000E54")]
		private MemoryShardMaskData memoryShardMaskData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000E55")]
		private Texture2D backgroundTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000E56")]
		private CancellationTokenSource shardAssetLoadingCTS = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x17000354")]
		public bool IsCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600131D")]
			[Cpp2IlInjected.Address(RVA = "0xF1A0C0", Offset = "0xF18AC0", VA = "0x180F1A0C0")]
			get
			{
				return _isCompleted;
			}
			[Cpp2IlInjected.Token(Token = "0x600131E")]
			[Cpp2IlInjected.Address(RVA = "0x113B2A0", Offset = "0x1139CA0", VA = "0x18113B2A0")]
			set
			{
				_isCompleted = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000355")]
		public MemoryShardItemData MemoryShardItemData
		{
			[Cpp2IlInjected.Token(Token = "0x600131F")]
			[Cpp2IlInjected.Address(RVA = "0x113B290", Offset = "0x1139C90", VA = "0x18113B290")]
			get
			{
				return _memoryShardItemData;
			}
			[Cpp2IlInjected.Token(Token = "0x6001320")]
			[Cpp2IlInjected.Address(RVA = "0x113B2B0", Offset = "0x1139CB0", VA = "0x18113B2B0")]
			set
			{
				//IL_0017: Expected O, but got I4
				//IL_002e: Expected O, but got I8
				//IL_003e: Expected O, but got I4
				//IL_0055: Expected O, but got I8
				_memoryShardItemData = value;
				MemoryShardMaskData memoryShardMaskData = this.memoryShardMaskData;
				int num = 0;
				if (memoryShardMaskData != (Object)num)
				{
					Addressables.Release(this.memoryShardMaskData);
					this.memoryShardMaskData = (MemoryShardMaskData)0;
				}
				Texture2D texture2D = backgroundTexture;
				int num2 = 0;
				if (texture2D != (Object)num2)
				{
					Addressables.Release(backgroundTexture);
					backgroundTexture = (Texture2D)0;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001321")]
		[Cpp2IlInjected.Address(RVA = "0x113AA80", Offset = "0x1139480", VA = "0x18113AA80", Slot = "19")]
		public override void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0146
			int num = 0;
			int num2 = 0;
			if (!Application.isPlaying)
			{
				return;
			}
			MemoryShardItemData memoryShardItemData = _memoryShardItemData;
			if (memoryShardItemData != null)
			{
				int iD = memoryShardItemData.ID;
			}
			IItemData _003CItemData_003Ek__BackingField = base.Model.ItemData;
			if (num != 0 && num != 0)
			{
				return;
			}
			IItemData _003CItemData_003Ek__BackingField2 = base.Model.ItemData;
			MemoryShardItemData memoryShardItemData2 = default(MemoryShardItemData);
			MemoryShardItemData = memoryShardItemData2;
			int count = ((RepeatedField<T>)(object)_memoryShardItemData.shards_).Count;
			Client client = default(Client);
			MapField<int, int> memoryShards_ = client.profile.player_.memoryShards_;
			int iD2 = _memoryShardItemData.ID;
			CancellationToken token = shardAssetLoadingCTS.Token;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
			CollectionTooltipMemoryShards shardTooltip = _shardTooltip;
			CollectionTooltipMemoryShardsModel collectionTooltipMemoryShardsModel = new CollectionTooltipMemoryShardsModel();
			IItemData itemData = (((CollectionTooltipModel)collectionTooltipMemoryShardsModel).ItemData = base.Model.ItemData);
			((CollectionTooltip)shardTooltip).Model = collectionTooltipMemoryShardsModel;
			CollectionTooltipMemoryShards shardTooltip2 = _shardTooltip;
			CollectionTooltipModel collectionTooltipModel = ((CollectionTooltip)shardTooltip2).Model;
			if (collectionTooltipModel != null)
			{
				collectionTooltipModel.UpdateDisplay(shardTooltip2);
				shardTooltip2.OnRefresh?.Invoke();
			}
			Client client2 = default(Client);
			Profile profile = client2.profile;
			_isCompleted = (byte)num != 0;
			if (count > 0)
			{
				MemoryShardItemData memoryShardItemData3 = _memoryShardItemData;
				ProfilePlayer player_ = profile.player_;
				int iD3 = memoryShardItemData3.ID;
				bool flag = default(bool);
				if (flag)
				{
					num++;
					_isCompleted = true;
				}
				_isCompleted = false;
			}
			base.RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001322")]
		[Cpp2IlInjected.Address(RVA = "0x113A8F0", Offset = "0x11392F0", VA = "0x18113A8F0")]
		public void HighlightMemory()
		{
			//Discarded unreachable code: IL_001c
			if (!_isCompleted)
			{
				_shardTooltip.gameObject.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001323")]
		[Cpp2IlInjected.Address(RVA = "0x113B1E0", Offset = "0x1139BE0", VA = "0x18113B1E0")]
		public void RemoveHighlightMemory()
		{
			//Discarded unreachable code: IL_0016
			GameObject gameObject = _shardTooltip.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001324")]
		[Cpp2IlInjected.Address(RVA = "0x113A940", Offset = "0x1139340", VA = "0x18113A940")]
		[AsyncStateMachine(typeof(_003CLoadTextureAsync_003Ed__18))]
		private Task LoadTextureAsync(MemoryShardItemData shardItemData, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001325")]
		[Cpp2IlInjected.Address(RVA = "0x113B010", Offset = "0x1139A10", VA = "0x18113B010", Slot = "16")]
		internal override void Release()
		{
			//Discarded unreachable code: IL_00b9
			//IL_001a: Expected O, but got I4
			//IL_0034: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_008e: Expected F4, but got I4
			//IL_0099: Expected O, but got I4
			Material material = _shardsImage.material;
			int num = 0;
			material.SetTexture("_BaseTex", (Texture)num);
			Material material2 = _shardsImage.material;
			int num2 = 0;
			material2.SetTexture("_Mask", (Texture)num2);
			Material material3 = _shardsImage.material;
			int num3 = 0;
			material3.SetTexture("_ContourAlpha", (Texture)num3);
			Material material4 = _shardsImage.material;
			int value = 0;
			material4.SetInt("_Pieces", value);
			Material material5 = _shardsImage.material;
			int num4 = 0;
			material5.SetFloat("_Alpha", num4);
			int num5 = 0;
			MemoryShardItemData = (MemoryShardItemData)num5;
			GameObject gameObject = _shardTooltip.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			base.Release();
		}

		[Cpp2IlInjected.Token(Token = "0x6001326")]
		[Cpp2IlInjected.Address(RVA = "0x113B220", Offset = "0x1139C20", VA = "0x18113B220")]
		public CollectionMemoryShardsView()
		{
		}
	}
}
