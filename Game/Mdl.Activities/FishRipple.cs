using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Navigation;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000B2F")]
	public class FishRipple : MonoBehaviour, IPlayerTaskData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000B30")]
		public struct RarityAndRipple
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003E35")]
			public FishRippleRarity Rarity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003E36")]
			public GameObject Prefab;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003E2E")]
		public AttentionVFX HiddenAttentionVFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003E2F")]
		public RarityAndRipple[] RippleVisualPrefabs = new RarityAndRipple[0];

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003E34")]
		[ItemID]
		[SerializeField]
		private int _fishItemID = (int)Item.Invalid;

		[Cpp2IlInjected.Token(Token = "0x1700070A")]
		public GameObject VisualInstance
		{
			[Cpp2IlInjected.Token(Token = "0x6003390")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CVisualInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003391")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CVisualInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070B")]
		internal BodyOfWater BodyOfWater
		{
			[Cpp2IlInjected.Token(Token = "0x6003392")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CBodyOfWater_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003393")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CBodyOfWater_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070C")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4003E32")]
		public uint PendingFishID
		{
			[Cpp2IlInjected.Token(Token = "0x6003394")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003395")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700070D")]
		public PendingFish PendingFish
		{
			[Cpp2IlInjected.Token(Token = "0x6003396")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CPendingFish_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003397")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CPendingFish_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700070E")]
		public Item FishItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003398")]
			[Cpp2IlInjected.Address(RVA = "0x13705A0", Offset = "0x136EFA0", VA = "0x1813705A0")]
			get
			{
				long num = Convert.ToInt64((uint)_fishItemID);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003399")]
		[Cpp2IlInjected.Address(RVA = "0x1370140", Offset = "0x136EB40", VA = "0x181370140")]
		internal void Init(uint pendingFishID, PendingFish pendingFish, BodyOfWater bodyOfWater)
		{
			//Discarded unreachable code: IL_0024
			PendingFishID = pendingFishID;
			PendingFish = pendingFish;
			BodyOfWater = bodyOfWater;
			FishRippleRarity rarity_ = pendingFish.rarity_;
			SetVisual(rarity_);
		}

		[Cpp2IlInjected.Token(Token = "0x600339A")]
		[Cpp2IlInjected.Address(RVA = "0x13701B0", Offset = "0x136EBB0", VA = "0x1813701B0")]
		public void SetVisual(FishRippleRarity rarity)
		{
			//Discarded unreachable code: IL_006a
			//IL_001f: Expected O, but got I4
			GameObject gameObject = VisualInstance;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				bool activeSelf = VisualInstance.activeSelf;
				UnityEngine.Object.Destroy(VisualInstance);
			}
			Func<RarityAndRipple, bool> func = (Func<RarityAndRipple, bool>)(object)(Func<T, TResult>)delegate
			{
				FishRippleRarity fishRippleRarity = rarity;
				bool result = default(bool);
				return result;
			};
			bool flag = default(bool);
			if (flag)
			{
				Transform transform = base.transform;
				GameObject gameObject2 = default(GameObject);
				VisualInstance = gameObject2;
				VisualInstance.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600339B")]
		[Cpp2IlInjected.Address(RVA = "0x13703D0", Offset = "0x136EDD0", VA = "0x1813703D0")]
		public void ShowVisual(bool show)
		{
			//Discarded unreachable code: IL_0025
			//IL_0010: Expected O, but got I4
			GameObject gameObject = VisualInstance;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				VisualInstance.gameObject.SetActive(show);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600339C")]
		[Cpp2IlInjected.Address(RVA = "0x1370470", Offset = "0x136EE70", VA = "0x181370470")]
		public void ToggleHiddenVFX(bool visible)
		{
			//Discarded unreachable code: IL_0020
			//IL_0010: Expected O, but got I4
			AttentionVFX hiddenAttentionVFX = HiddenAttentionVFX;
			int num = 0;
			if (hiddenAttentionVFX != (UnityEngine.Object)num)
			{
				HiddenAttentionVFX.enabled = visible;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600339D")]
		[Cpp2IlInjected.Address(RVA = "0x1370500", Offset = "0x136EF00", VA = "0x181370500")]
		public FishRipple()
		{
		}//IL_001b: Expected I4, but got O

	}
}
