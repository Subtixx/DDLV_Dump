using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003F4")]
	public class DebugSettingSelectionItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001368")]
		[SerializeField]
		private TextBase _tfLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001369")]
		private Action<string, object> _onSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400136A")]
		private object _itemData;

		[Cpp2IlInjected.Token(Token = "0x600191B")]
		[Cpp2IlInjected.Address(RVA = "0x1556E40", Offset = "0x1555840", VA = "0x181556E40")]
		public void RefreshData(string itemText, object itemData, Action<string, object> onSelected)
		{
			_tfLabel.Text = itemText;
			_itemData = itemData;
			_onSelected = onSelected;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600191C")]
		[Cpp2IlInjected.Address(RVA = "0x1556DE0", Offset = "0x15557E0", VA = "0x181556DE0")]
		public void OnClicked()
		{
			//Discarded unreachable code: IL_002a
			Action<string, object> onSelected = _onSelected;
			if (onSelected != null)
			{
				TextBase tfLabel = _tfLabel;
				object itemData = _itemData;
				string text = tfLabel._text;
				onSelected((T1)text, (T2)itemData);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600191D")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public DebugSettingSelectionItem()
		{
		}
	}
}
