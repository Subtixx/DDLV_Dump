using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Display
{
	[Cpp2IlInjected.Token(Token = "0x200081D")]
	public class ClothingMannequin : BaseMannequin
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002D4B")]
		public AssetReferenceMaterial BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002D4C")]
		public AssetReferenceMaterial BodyMaterialDark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002D4D")]
		public Renderer StandRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002D4E")]
		private Material loadedBodyMaterial;

		[Cpp2IlInjected.Token(Token = "0x6002461")]
		[Cpp2IlInjected.Address(RVA = "0xA86D40", Offset = "0xA85740", VA = "0x180A86D40", Slot = "6")]
		public override bool HasOffsetFromRoot(Item attachedItem)
		{
			ItemType itemType = default(ItemType);
			ClothingItemType clothingItemType = default(ClothingItemType);
			do
			{
				if (itemType != ItemType.Clothing)
				{
					return true;
				}
			}
			while (clothingItemType == ClothingItemType.AccHeadEar);
			return 0 != 11;
		}

		[Cpp2IlInjected.Token(Token = "0x6002462")]
		[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0", Slot = "7")]
		public override Renderer GetVisualRenderer()
		{
			SkinnedMeshRenderer skinnedMeshRenderer = combinedMannequin;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002463")]
		[Cpp2IlInjected.Address(RVA = "0xA86C30", Offset = "0xA85630", VA = "0x180A86C30", Slot = "5")]
		[AsyncStateMachine(typeof(_003CDoAttachObject_003Ed__6))]
		protected override Task DoAttachObject(GameObject objToAttach)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6002464")]
		[Cpp2IlInjected.Address(RVA = "0xA86DC0", Offset = "0xA857C0", VA = "0x180A86DC0", Slot = "4")]
		protected override void OnDestroy()
		{
			//IL_0010: Expected O, but got I4
			//IL_0027: Expected O, but got I8
			Material material = loadedBodyMaterial;
			int num = 0;
			if (material != (Object)num)
			{
				Addressables.Release(loadedBodyMaterial);
				loadedBodyMaterial = (Material)0;
			}
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6002465")]
		[Cpp2IlInjected.Address(RVA = "0xA86EA0", Offset = "0xA858A0", VA = "0x180A86EA0")]
		public ClothingMannequin()
		{
		}
	}
}
