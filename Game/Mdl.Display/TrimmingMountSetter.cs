using System.Threading;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Environments;
using UnityEngine;

namespace Mdl.Display
{
	[Cpp2IlInjected.Token(Token = "0x2000822")]
	public class TrimmingMountSetter : TrimmingSetter
	{
		[Cpp2IlInjected.Token(Token = "0x1700052C")]
		public override TrimmingItemType HandledTrimmingItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6002478")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0", Slot = "4")]
			get
			{
				return TrimmingItemType;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052D")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x78"), Cpp2IlInjected.Token(Token = "0x4002D60")]
		public TrimmingItemType TrimmingItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6002479")]
			[Cpp2IlInjected.Address(RVA = "0x70C9F0", Offset = "0x70B3F0", VA = "0x18070C9F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600247A")]
			[Cpp2IlInjected.Address(RVA = "0x70CDE0", Offset = "0x70B7E0", VA = "0x18070CDE0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600247B")]
		[Cpp2IlInjected.Address(RVA = "0x13E0000", Offset = "0x13DEA00", VA = "0x1813E0000")]
		public void SetTrimmingItem(Item item)
		{
			TrimmingItemType trimmingItemType = default(TrimmingItemType);
			TrimmingItemType = trimmingItemType;
		}

		[Cpp2IlInjected.Token(Token = "0x600247C")]
		[Cpp2IlInjected.Address(RVA = "0x13E0070", Offset = "0x13DEA70", VA = "0x1813E0070")]
		public TrimmingMountSetter()
		{
			base.cts = new CancellationTokenSource();
			((MonoBehaviour)this)._002Ector();
		}
	}
}
