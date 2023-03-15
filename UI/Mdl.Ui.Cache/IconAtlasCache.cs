using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Cache;
using UnityEngine;

namespace Mdl.Ui.Cache
{
	[Cpp2IlInjected.Token(Token = "0x2000964")]
	public class IconAtlasCache : AssetCache<string, AtlassedIcon>
	{
		[Cpp2IlInjected.Token(Token = "0x40037D4")]
		private const int IconAtlasResMultiplier = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40037D5")]
		public int acquired;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40037D6")]
		public int rowCount = 8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40037D7")]
		public int resolution = 128;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40037D8")]
		private bool[] _usedSlots;

		[Cpp2IlInjected.Token(Token = "0x6003B24")]
		[Cpp2IlInjected.Address(RVA = "0x130F940", Offset = "0x130E340", VA = "0x18130F940")]
		private void Awake()
		{
			int num = rowCount;
			int num2 = num * num;
			int num3 = num2 - 1;
			bool[] array = (_usedSlots = new bool[num2]);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B25")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		private void OnDestroy()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003B26")]
		[Cpp2IlInjected.Address(RVA = "0x130F7A0", Offset = "0x130E1A0", VA = "0x18130F7A0")]
		private int AcquireSlot(bool cleanedUpCache = false)
		{
			//Discarded unreachable code: IL_004b, IL_0067
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected I4, but got Unknown
			bool[] usedSlots = _usedSlots;
			int length = usedSlots.Length;
			int num = acquired;
			int num2 = rowCount;
			bool[] array = (_usedSlots = new bool[num2 * num2]);
			bool[] usedSlots2 = _usedSlots;
			num = length;
			Array.Copy(usedSlots, usedSlots2, num);
			bool[] usedSlots3 = _usedSlots;
			return length;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B27")]
		[Cpp2IlInjected.Address(RVA = "0x130FC90", Offset = "0x130E690", VA = "0x18130FC90")]
		private void ReleaseSlot(int slot)
		{
			//Discarded unreachable code: IL_000c
			if (slot != -1)
			{
				bool[] usedSlots = _usedSlots;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003B28")]
		[Cpp2IlInjected.Address(RVA = "0x130FAE0", Offset = "0x130E4E0", VA = "0x18130FAE0", Slot = "4")]
		[IteratorStateMachine(typeof(_003CCreateAsset_003Ed__9))]
		protected override IEnumerator CreateAsset(CachedAsset cachedAsset)
		{
			int _003C_003E1__state = default(int);
			_003CCreateAsset_003Ed__9 _003CCreateAsset_003Ed__ = new _003CCreateAsset_003Ed__9(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCreateAsset_003Ed__._003C_003E4__this = this;
			_003CCreateAsset_003Ed__.cachedAsset = cachedAsset;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B29")]
		[Cpp2IlInjected.Address(RVA = "0x130F9A0", Offset = "0x130E3A0", VA = "0x18130F9A0")]
		[AsyncStateMachine(typeof(_003CCreateAssetAsync_003Ed__10))]
		private Task<Texture> CreateAssetAsync(CachedAsset cachedAsset)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Texture>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B2A")]
		[Cpp2IlInjected.Address(RVA = "0x130FB70", Offset = "0x130E570", VA = "0x18130FB70", Slot = "5")]
		protected override void DestroyAsset(CachedAsset asset)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003B2B")]
		[Cpp2IlInjected.Address(RVA = "0x130FD60", Offset = "0x130E760", VA = "0x18130FD60")]
		public IconAtlasCache()
		{
			//IL_0009: Expected I4, but got I8
			//IL_0016: Expected I4, but got I8
			((AssetCache<Key, AssetType>)(object)this)._002Ector();
		}
	}
}
