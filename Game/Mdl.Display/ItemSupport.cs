using System;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Navigation;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Display
{
	[Cpp2IlInjected.Token(Token = "0x2000820")]
	public abstract class ItemSupport : MonoBehaviour, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002D5D")]
		[SerializeField]
		[HideInInspector]
		private int _item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002D5E")]
		protected IAvatarInfoProvider avatarInfoProvider;

		[Cpp2IlInjected.Token(Token = "0x1700052B")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600246C")]
			[Cpp2IlInjected.Address(RVA = "0x11C3EF0", Offset = "0x11C28F0", VA = "0x1811C3EF0")]
			get
			{
				long num = Convert.ToInt64((uint)_item);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600246D")]
		[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
		public void SetAvatarInfoProvider(IAvatarInfoProvider _avatarInfoProvider)
		{
			avatarInfoProvider = _avatarInfoProvider;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600246E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "4")]
		protected virtual void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600246F")]
		[Cpp2IlInjected.Address(RVA = "0x11C3ED0", Offset = "0x11C28D0", VA = "0x1811C3ED0")]
		public Task AttachObject(GameObject objToAttach, Item item)
		{
			//IL_0007: Expected I4, but got O
			_item = (int)item;
			return DoAttachObject(objToAttach);
		}

		[Cpp2IlInjected.Token(Token = "0x6002470")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract Task DoAttachObject(GameObject objToAttach);

		[Cpp2IlInjected.Token(Token = "0x6002471")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract bool HasOffsetFromRoot(Item attachedItem);

		[Cpp2IlInjected.Token(Token = "0x6002472")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract Renderer GetVisualRenderer();

		[Cpp2IlInjected.Token(Token = "0x6002473")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected ItemSupport()
		{
		}
	}
}
