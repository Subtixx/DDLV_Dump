using System.Collections.Generic;
using System.Xml;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.ImageRendering;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui.AssetPresentation
{
	[Cpp2IlInjected.Token(Token = "0x20009D5")]
	internal class AssetRendererTab : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40039C0")]
		public string labelName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40039C1")]
		public float imageFill = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40039C2")]
		public List<ItemType> assetTypes = (List<ItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40039C3")]
		public List<BuildingItemType> renderBuildingItems = (List<BuildingItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40039C4")]
		public List<ActivityItemType> renderActivityItems = (List<ActivityItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40039C5")]
		public List<FurnitureItemType> renderFurnitureItems = (List<FurnitureItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40039C6")]
		public AssetPresentationRenderer assetRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40039C7")]
		public Text label;

		[Cpp2IlInjected.Token(Token = "0x6003D87")]
		[Cpp2IlInjected.Address(RVA = "0x880870", Offset = "0x87F270", VA = "0x180880870")]
		private void Awake()
		{
			//Discarded unreachable code: IL_000d
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)label).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6003D88")]
		[Cpp2IlInjected.Address(RVA = "0x8808A0", Offset = "0x87F2A0", VA = "0x1808808A0")]
		public AssetRendererTab()
		{
		}
	}
}
