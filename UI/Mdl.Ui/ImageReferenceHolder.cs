using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Scene;
using Mdl.Avatar;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	public class ImageReferenceHolder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private bool _initialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		private Dictionary<Toolbox.ToolType, UnityEngine.AddressableAssets.AssetReferenceTexture> _dictToolIcons = (Dictionary<Toolbox.ToolType, UnityEngine.AddressableAssets.AssetReferenceTexture>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		private Dictionary<VillageAreaType, UnityEngine.AddressableAssets.AssetReferenceTexture> _dictVillageAreaIcons = (Dictionary<VillageAreaType, UnityEngine.AddressableAssets.AssetReferenceTexture>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		private Dictionary<int, UnityEngine.AddressableAssets.AssetReferenceTexture> _dictNonVillageLocation = (Dictionary<int, UnityEngine.AddressableAssets.AssetReferenceTexture>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		[SerializeField]
		private ToolIconReference[] _toolIcons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		[SerializeField]
		private VillageAreaIconReference[] _villageAreaIcons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		[SerializeField]
		private UnityEngine.AddressableAssets.AssetReferenceTexture _villageAreaEverywhereIconReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		[SerializeField]
		private NonVillageLocation[] _nonVillageLocationIcons;

		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x1312400", Offset = "0x1310E00", VA = "0x181312400")]
		private void Init()
		{
			//Discarded unreachable code: IL_0029, IL_002e, IL_003c, IL_0068, IL_006d, IL_007b, IL_00a7, IL_00ac, IL_00ba, IL_00c6
			ToolIconReference[] toolIcons = _toolIcons;
			int num = 0;
			int length = toolIcons.Length;
			if (num < length)
			{
				Dictionary<Toolbox.ToolType, UnityEngine.AddressableAssets.AssetReferenceTexture> dictToolIcons = _dictToolIcons;
				num += 2;
				num += num;
				throw new NullReferenceException();
			}
			int length2 = _villageAreaIcons.Length;
			if (num < length2)
			{
				Dictionary<VillageAreaType, UnityEngine.AddressableAssets.AssetReferenceTexture> dictVillageAreaIcons = _dictVillageAreaIcons;
				num += 2;
				num += num;
				throw new NullReferenceException();
			}
			int length3 = _nonVillageLocationIcons.Length;
			if (num < length3)
			{
				Dictionary<int, UnityEngine.AddressableAssets.AssetReferenceTexture> dictNonVillageLocation = _dictNonVillageLocation;
				num += 2;
				num += num;
				throw new NullReferenceException();
			}
			_initialized = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0x1312220", Offset = "0x1310C20", VA = "0x181312220")]
		public UnityEngine.AddressableAssets.AssetReferenceTexture GetReference(Toolbox.ToolType key)
		{
			//Discarded unreachable code: IL_001c, IL_0020, IL_0029
			if (!_initialized)
			{
				Init();
			}
			Dictionary<Toolbox.ToolType, UnityEngine.AddressableAssets.AssetReferenceTexture> dictToolIcons = _dictToolIcons;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x13122C0", Offset = "0x1310CC0", VA = "0x1813122C0")]
		public UnityEngine.AddressableAssets.AssetReferenceTexture GetReference(VillageAreaType key)
		{
			//Discarded unreachable code: IL_001c, IL_0020, IL_0029
			if (!_initialized)
			{
				Init();
			}
			Dictionary<VillageAreaType, UnityEngine.AddressableAssets.AssetReferenceTexture> dictVillageAreaIcons = _dictVillageAreaIcons;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x1312360", Offset = "0x1310D60", VA = "0x181312360")]
		public UnityEngine.AddressableAssets.AssetReferenceTexture GetReference(int sceneId)
		{
			//Discarded unreachable code: IL_001c, IL_0020, IL_002d
			//IL_002c: Expected O, but got I4
			if (!_initialized)
			{
				Init();
			}
			Dictionary<int, UnityEngine.AddressableAssets.AssetReferenceTexture> dictNonVillageLocation = _dictNonVillageLocation;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0x63F740", Offset = "0x63E140", VA = "0x18063F740")]
		public UnityEngine.AddressableAssets.AssetReferenceTexture GetEverywhereReference()
		{
			return _villageAreaEverywhereIconReference;
		}

		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x1312640", Offset = "0x1311040", VA = "0x181312640")]
		public ImageReferenceHolder()
		{
		}
	}
}
