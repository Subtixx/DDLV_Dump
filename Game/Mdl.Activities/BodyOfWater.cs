using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Definitions.Scene;
using Google.Protobuf.Collections;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B28")]
	public class BodyOfWater : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000B29")]
		public struct RarityAndRipple
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003E1F")]
			public FishRippleRarity Rarity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003E20")]
			public GameObject Prefab;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4003E12")]
		[ItemID]
		[SerializeField]
		private int _conditionItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003E13")]
		[SerializeField]
		[ItemID]
		private int _fishItemID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003E14")]
		public RarityAndRipple[] RipplePrefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003E15")]
		public bool UseForwardToFindShore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4003E16")]
		public float MinDistanceFromShore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003E17")]
		public float MaxDistanceFromShore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4003E18")]
		public float MaxSizeOffset;

		[Cpp2IlInjected.Token(Token = "0x4003E19")]
		public const float FishRippleHeightOffset = -0.25f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003E1C")]
		private GridScript grid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003E1D")]
		private GridArea fishRippleGridArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003E1E")]
		private bool init;

		[Cpp2IlInjected.Token(Token = "0x17000702")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4003E10")]
		public VillageAreaType? VillageArea
		{
			[Cpp2IlInjected.Token(Token = "0x6003370")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003371")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AC0", Offset = "0x6E44C0", VA = "0x1806E5AC0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000703")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4003E11")]
		public Item SceneItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003372")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003373")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000704")]
		public Item ConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003374")]
			[Cpp2IlInjected.Address(RVA = "0x16434A0", Offset = "0x1641EA0", VA = "0x1816434A0")]
			get
			{
				long num = Convert.ToInt64((uint)_conditionItem);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000705")]
		public Item RequestedFishItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003375")]
			[Cpp2IlInjected.Address(RVA = "0x1643690", Offset = "0x1642090", VA = "0x181643690")]
			get
			{
				long num = Convert.ToInt64((uint)_fishItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000706")]
		public FishingDataItemData FishingData
		{
			[Cpp2IlInjected.Token(Token = "0x6003376")]
			[Cpp2IlInjected.Address(RVA = "0x1643540", Offset = "0x1641F40", VA = "0x181643540")]
			get
			{
				//Discarded unreachable code: IL_0028
				IEnumerable<> allByType = ItemDatabase.Instance.GetAllByType<FishingDataItemData, ActivityDataItemType>(ItemType.ActivityData, ActivityDataItemType.FishingData);
				Func<FishingDataItemData, bool> func = (Func<FishingDataItemData, bool>)(object)(Func<T, TResult>)delegate(FishingDataItemData x)
				{
					//Discarded unreachable code: IL_0019
					//IL_0019: Expected I4, but got O
					Item item = x.result_.Item;
					int fishItemID = _fishItemID;
					return (byte)(int)typeof(Item).TypeHandle != 0;
				};
				return Enumerable.FirstOrDefault<FishingDataItemData>(allByType, (Func<, >)(object)func);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000707")]
		public float FishRippleHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6003377")]
			[Cpp2IlInjected.Address(RVA = "0x1643500", Offset = "0x1641F00", VA = "0x181643500")]
			get
			{
				//Discarded unreachable code: IL_000e
				Transform transform = base.transform;
				Vector3 vector = default(Vector3);
				return vector.y;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000708")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x48"), Cpp2IlInjected.Token(Token = "0x4003E1A")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6003378")]
			[Cpp2IlInjected.Address(RVA = "0x6EDEE0", Offset = "0x6EC8E0", VA = "0x1806EDEE0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003379")]
			[Cpp2IlInjected.Address(RVA = "0x6EDF20", Offset = "0x6EC920", VA = "0x1806EDF20")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000709")]
		public GameObject Ripple
		{
			[Cpp2IlInjected.Token(Token = "0x600337A")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CRipple_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600337B")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			private set
			{
				_003CRipple_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600337C")]
		[Cpp2IlInjected.Address(RVA = "0x1642EE0", Offset = "0x16418E0", VA = "0x181642EE0")]
		private void Start()
		{
			Init();
		}

		[Cpp2IlInjected.Token(Token = "0x600337D")]
		[Cpp2IlInjected.Address(RVA = "0x1642B00", Offset = "0x1641500", VA = "0x181642B00")]
		private void Init()
		{
			//IL_0031: Expected I4, but got I8
			//IL_003a: Expected I4, but got I8
			//IL_0076: Expected O, but got I4
			//IL_008a: Expected O, but got I8
			if (!init)
			{
				GridScript gridScript = (grid = GetComponentInParent<GridScript>());
				GridAreaData gridAreaData = new GridAreaData();
				gridAreaData.AcceptedFloorTypesFlag = 512;
				gridAreaData.sizeX_ = 2;
				gridAreaData.sizeY_ = 2;
				gridAreaData.SetLayersSize();
				int num = 0;
				int num2 = 0;
				int count = ((RepeatedField<T>)(object)gridAreaData.layers_).Count;
				if (num2 < count)
				{
					RepeatedField<int> layers_ = gridAreaData.layers_;
					num++;
				}
				VillageArea componentInParent = GetComponentInParent<VillageArea>();
				int num3 = 0;
				if (componentInParent != (UnityEngine.Object)num3)
				{
					ulong num4 = default(ulong);
					VillageArea = (VillageAreaType?)(object)num4;
					throw new NullReferenceException();
				}
				Item item = default(Item);
				SceneItem = item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600337E")]
		[Cpp2IlInjected.Address(RVA = "0x1641E30", Offset = "0x1640830", VA = "0x181641E30")]
		internal bool AddFish(uint pendingFishID, PendingFish pendingFish)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600337F")]
		[Cpp2IlInjected.Address(RVA = "0x1642830", Offset = "0x1641230", VA = "0x181642830")]
		private GameObject FindPrefabForRarity(FishRippleRarity rarity)
		{
			Func<RarityAndRipple, bool> func = (Func<RarityAndRipple, bool>)(object)(Func<T, TResult>)delegate
			{
				FishRippleRarity fishRippleRarity = rarity;
				bool result = default(bool);
				return result;
			};
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003380")]
		[Cpp2IlInjected.Address(RVA = "0x1642DC0", Offset = "0x16417C0", VA = "0x181642DC0")]
		public bool RemoveFish(uint pendingFishID)
		{
			//IL_0010: Expected O, but got I4
			//IL_0033: Expected O, but got I8
			GameObject gameObject = Ripple;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				GameObject gameObject2 = Ripple;
				bool flag = default(bool);
				if (flag)
				{
					UnityEngine.Object.Destroy(Ripple);
					Ripple = (GameObject)0;
					return true;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003381")]
		[Cpp2IlInjected.Address(RVA = "0x1642740", Offset = "0x1641140", VA = "0x181642740")]
		public bool EmptyBodyOfWater()
		{
			//IL_0010: Expected O, but got I4
			//IL_0033: Expected O, but got I8
			GameObject gameObject = Ripple;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				GameObject gameObject2 = Ripple;
				bool flag = default(bool);
				if (flag)
				{
					UnityEngine.Object.Destroy(Ripple);
					Ripple = (GameObject)0;
					return true;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003382")]
		[Cpp2IlInjected.Address(RVA = "0x1642910", Offset = "0x1641310", VA = "0x181642910")]
		internal bool FishRippleIsInvalid(out uint invalidPendingFishID)
		{
			//IL_0019: Expected O, but got I4
			int num = (int)(invalidPendingFishID.m_value = 0u);
			GameObject gameObject = Ripple;
			int num2 = 0;
			if (!(gameObject == (UnityEngine.Object)num2))
			{
				GameObject gameObject2 = Ripple;
				GridScript gridScript = grid;
				Transform transform = gameObject2.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				bool flag = default(bool);
				if (flag)
				{
					GameObject gameObject3 = Ripple;
					GridScript gridScript2 = grid;
					Transform transform2 = gameObject3.transform;
					Vector3 vector2 = default(Vector3);
					float z2 = vector2.z;
					GridScript gridScript3 = grid;
					bool flag2 = default(bool);
					if (!flag2)
					{
						uint num3 = (invalidPendingFishID.m_value = Ripple.GetComponent<FishRipple>().PendingFishID);
					}
				}
				return true;
			}
			int num4 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003383")]
		[Cpp2IlInjected.Address(RVA = "0x1642570", Offset = "0x1640F70", VA = "0x181642570")]
		public bool AreConditionsTrue()
		{
			//Discarded unreachable code: IL_0024
			long num = Convert.ToInt64((uint)_conditionItem);
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003384")]
		[Cpp2IlInjected.Address(RVA = "0x16433F0", Offset = "0x1641DF0", VA = "0x1816433F0")]
		public BodyOfWater()
		{
			//IL_000f: Expected I4, but got O
			int num = 0;
			_fishItemID = (int)Item.Invalid;
			RipplePrefabs = new RarityAndRipple[num];
			MinDistanceFromShore = 4f;
			MaxDistanceFromShore = 6f;
			MaxSizeOffset = 4f;
			base._002Ector();
		}
	}
}
