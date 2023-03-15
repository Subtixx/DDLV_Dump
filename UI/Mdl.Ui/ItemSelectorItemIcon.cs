using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Meta;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20007BE")]
	public class ItemSelectorItemIcon : IItemSelectorItem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002D85")]
		private AssetReferenceTexture2D _texture;

		[Cpp2IlInjected.Token(Token = "0x170006F0")]
		public bool CanHaveAdditionalIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600317F")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "4")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F1")]
		public bool CanHaveCountIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x6003180")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "5")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F2")]
		public bool AlwaysAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6003181")]
			[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "6")]
			get
			{
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F3")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6003182")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F4")]
		public ItemType? ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6003183")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "8")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F5")]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6003184")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "9")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003185")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public ItemSelectorItemIcon(AssetReferenceTexture2D texture)
		{
			_texture = texture;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003186")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "10")]
		public bool ShowQuestMarker(IEnumerable<ProfileWorld.FilterInfo> quests)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003187")]
		[Cpp2IlInjected.Address(RVA = "0x1320680", Offset = "0x131F080", VA = "0x181320680", Slot = "11")]
		[AsyncStateMachine(typeof(_003CLoadIcon_003Ed__15))]
		public Task LoadIcon(AsyncAtlassedIcon icon, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}
	}
}
