using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Meta.Customization;
using UnityEngine;

namespace Mdl.ImageRendering
{
	[Cpp2IlInjected.Token(Token = "0x20003E7")]
	public class ClothingDesignsRenderer : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20003E8")]
		public class ClothingCameraOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400194E")]
			public ClothingItemType type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400194F")]
			public Transform transform;

			[Cpp2IlInjected.Token(Token = "0x60010C7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ClothingCameraOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400194C")]
		public Transform clothingTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400194D")]
		public List<ClothingCameraOverride> clothingCameraOverrides = (List<ClothingCameraOverride>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x60010C4")]
		[Cpp2IlInjected.Address(RVA = "0xA86030", Offset = "0xA84A30", VA = "0x180A86030")]
		private Transform FindClothingCam(ClothingItemType type)
		{
			List<ClothingCameraOverride> list = clothingCameraOverrides;
			Predicate<ClothingCameraOverride> predicate = (Predicate<ClothingCameraOverride>)(object)(Predicate<T>)delegate(ClothingCameraOverride c)
			{
				//Discarded unreachable code: IL_0011
				ClothingItemType clothingItemType = type;
				return c.type == clothingItemType;
			};
			ClothingCameraOverride clothingCameraOverride = (ClothingCameraOverride)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
			if (clothingCameraOverride != null)
			{
				return clothingCameraOverride.transform;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010C5")]
		[Cpp2IlInjected.Address(RVA = "0xA86130", Offset = "0xA84B30", VA = "0x180A86130")]
		[AsyncStateMachine(typeof(_003CRenderDesign_003Ed__4))]
		public Task RenderDesign(Design design, RenderTexture rt)
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60010C6")]
		[Cpp2IlInjected.Address(RVA = "0xA86260", Offset = "0xA84C60", VA = "0x180A86260")]
		public ClothingDesignsRenderer()
		{
		}
	}
}
