using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mdl.Cache;
using UnityEngine;

namespace Mdl.Ui.Cache
{
	[Cpp2IlInjected.Token(Token = "0x2000968")]
	public class SpriteCache : AssetCache<string, Sprite>
	{
		[Cpp2IlInjected.Token(Token = "0x6003B35")]
		[Cpp2IlInjected.Address(RVA = "0x15FF940", Offset = "0x15FE340", VA = "0x1815FF940", Slot = "4")]
		[IteratorStateMachine(typeof(_003CCreateAsset_003Ed__0))]
		protected override IEnumerator CreateAsset(CachedAsset cachedAsset)
		{
			int _003C_003E1__state = default(int);
			_003CCreateAsset_003Ed__0 _003CCreateAsset_003Ed__ = new _003CCreateAsset_003Ed__0(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CCreateAsset_003Ed__._003C_003E4__this = this;
			_003CCreateAsset_003Ed__.cachedAsset = cachedAsset;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003B36")]
		[Cpp2IlInjected.Address(RVA = "0x15FF9D0", Offset = "0x15FE3D0", VA = "0x1815FF9D0", Slot = "5")]
		protected override void DestroyAsset(CachedAsset asset)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6003B37")]
		[Cpp2IlInjected.Address(RVA = "0x15FF830", Offset = "0x15FE230", VA = "0x1815FF830")]
		[AsyncStateMachine(typeof(_003CCreateAssetAsync_003Ed__2))]
		private Task CreateAssetAsync(CachedAsset cachedAsset)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003B38")]
		[Cpp2IlInjected.Address(RVA = "0x15FFAA0", Offset = "0x15FE4A0", VA = "0x1815FFAA0")]
		public SpriteCache()
		{
			((AssetCache<Key, AssetType>)(object)this)._002Ector();
		}
	}
}
