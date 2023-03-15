using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using PlayFab.AdminModels;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x200098E")]
	public class TagFilter : Filter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400386E")]
		public Color defaultColor;

		[Cpp2IlInjected.Token(Token = "0x1700084D")]
		public ITagData TagData
		{
			[Cpp2IlInjected.Token(Token = "0x6003C1D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CTagData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6003C1E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			private set
			{
				_003CTagData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700084E")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400386D")]
		public TagItem TagItem
		{
			[Cpp2IlInjected.Token(Token = "0x6003C1F")]
			[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6003C20")]
			[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700084F")]
		public override int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6003C22")]
			[Cpp2IlInjected.Address(RVA = "0x17E67D0", Offset = "0x17E51D0", VA = "0x1817E67D0", Slot = "5")]
			get
			{
				ITagData tagData = TagData;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000850")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6003C23")]
			[Cpp2IlInjected.Address(RVA = "0x17E6820", Offset = "0x17E5220", VA = "0x1817E6820", Slot = "6")]
			get
			{
				ITagData tagData = TagData;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000851")]
		public override string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003C24")]
			[Cpp2IlInjected.Address(RVA = "0x17E6740", Offset = "0x17E5140", VA = "0x1817E6740", Slot = "7")]
			get
			{
				//Discarded unreachable code: IL_0009
				ITagData tagData = TagData;
				string result = default(string);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000852")]
		public override Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6003C25")]
			[Cpp2IlInjected.Address(RVA = "0x17E6690", Offset = "0x17E5090", VA = "0x1817E6690", Slot = "8")]
			get
			{
				int num = 0;
				TagItemType tagItemType = default(TagItemType);
				bool flag = default(bool);
				if (tagItemType != TagItemType.DominantColor || flag)
				{
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C21")]
		[Cpp2IlInjected.Address(RVA = "0x17E64C0", Offset = "0x17E4EC0", VA = "0x1817E64C0")]
		public TagFilter(ITagData tag, int order = 0)
		{
			//Discarded unreachable code: IL_003b
			//IL_0022: Expected O, but got I4
			((RevokeItemError)(object)this)._002Ector();
			TagData = tag;
			ITagData tagData = TagData;
			base.Order = order;
			int num = default(int);
			TagItem = (TagItem)num;
			TagItem tagItem = TagItem;
			TagItemType tagItemType = default(TagItemType);
			if (tagItemType <= TagItemType.DominantColor)
			{
				base.Group = "ApparelStyle";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C26")]
		[Cpp2IlInjected.Address(RVA = "0x17E6220", Offset = "0x17E4C20", VA = "0x1817E6220", Slot = "9")]
		public override bool Retains(object item)
		{
			TagItem tagItem = TagItem;
			TagItemType tagItemType = default(TagItemType);
			if (tagItemType != TagItemType.Universe)
			{
				if (tagItemType == TagItemType.ApparelStyle)
				{
					goto IL_0041;
				}
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
			bool flag = default(bool);
			if (tagItemType != 0 && flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				SetItemData setItemData = default(SetItemData);
				RepeatedField<int> tags_ = setItemData.tags_;
				ITagData tagData = TagData;
				bool result = default(bool);
				return result;
			}
			goto IL_0041;
			IL_0041:
			int num3 = 0;
			throw new NullReferenceException();
		}
	}
}
