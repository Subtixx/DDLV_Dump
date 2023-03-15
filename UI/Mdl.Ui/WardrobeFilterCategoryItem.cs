using System.Xml;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000787")]
	[RequiredAllNotNull]
	public class WardrobeFilterCategoryItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002BD1")]
		public Image Background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002BD2")]
		public TextBase Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002BD3")]
		public Button ButtonComponent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002BD4")]
		public int ItemIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002BD5")]
		public IItemData TagItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002BD6")]
		public int extraSize = 70;

		[Cpp2IlInjected.Token(Token = "0x600301C")]
		[Cpp2IlInjected.Address(RVA = "0x14E4120", Offset = "0x14E2B20", VA = "0x1814E4120")]
		public void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0028
			RectTransform component = Label.GetComponent<RectTransform>();
			LayoutRebuilder.ForceRebuildLayoutImmediate(component);
			LayoutElement component2 = GetComponent<LayoutElement>();
			Vector2 sizeDelta = component.sizeDelta;
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)component2).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x600301D")]
		[Cpp2IlInjected.Address(RVA = "0x14E40F0", Offset = "0x14E2AF0", VA = "0x1814E40F0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0011
			ButtonComponent.m_OnClick.RemoveAllListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x600301E")]
		[Cpp2IlInjected.Address(RVA = "0x14E4210", Offset = "0x14E2C10", VA = "0x1814E4210")]
		public WardrobeFilterCategoryItem()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
