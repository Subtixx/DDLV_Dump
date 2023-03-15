using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002AE")]
	[CreateAssetMenu]
	public class PrefabSelectorConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20002AF")]
		public class PrefabRefPair
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001515")]
			public AssetReferenceGameObject source;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001516")]
			public AssetReferenceGameObject dest;

			[Cpp2IlInjected.Token(Token = "0x6000BCA")]
			[Cpp2IlInjected.Address(RVA = "0x1603BD0", Offset = "0x16025D0", VA = "0x181603BD0")]
			private PrefabRefPair()
			{
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001513")]
		public List<PrefabRefPair> PrefabList = (List<PrefabRefPair>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001514")]
		private Dictionary<string, AssetReferenceGameObject> PrefabDict = (Dictionary<string, AssetReferenceGameObject>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0xCB7230", Offset = "0xCB5C30", VA = "0x180CB7230")]
		public void Awake()
		{
			BuildDict();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0xCB73B0", Offset = "0xCB5DB0", VA = "0x180CB73B0")]
		public unsafe AssetReferenceGameObject GetMappedAsset(AssetReferenceGameObject source)
		{
			Dictionary<string, AssetReferenceGameObject> prefabDict = PrefabDict;
			int num = 0;
			string assetGUID = source.AssetGUID;
			bool flag = ((Dictionary<TKey, TValue>)(object)prefabDict).TryGetValue((TKey)assetGUID, out *(TValue*)num);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0xCB7240", Offset = "0xCB5C40", VA = "0x180CB7240")]
		private void BuildDict()
		{
			//Discarded unreachable code: IL_001d, IL_0023, IL_0029
			List<PrefabRefPair> prefabList = PrefabList;
			bool flag = default(bool);
			if (flag)
			{
				while (!flag)
				{
				}
				Dictionary<string, AssetReferenceGameObject> prefabDict = PrefabDict;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0xCB7450", Offset = "0xCB5E50", VA = "0x180CB7450")]
		public void OnValidate()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0xCB7720", Offset = "0xCB6120", VA = "0x180CB7720")]
		public PrefabSelectorConfig()
		{
		}
	}
}
