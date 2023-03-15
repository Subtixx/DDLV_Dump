using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Avatar
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000A51")]
	public class AssetReferenceMaterial : AssetReferenceT<Material>
	{
		[Cpp2IlInjected.Token(Token = "0x600301F")]
		[Cpp2IlInjected.Address(RVA = "0xA457E0", Offset = "0xA441E0", VA = "0x180A457E0")]
		public AssetReferenceMaterial(string guid)
		{
			((AssetReferenceT<TObject>)(object)this)._002Ector(guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6003020")]
		[Cpp2IlInjected.Address(RVA = "0xA456A0", Offset = "0xA440A0", VA = "0x180A456A0")]
		[AsyncStateMachine(typeof(_003CGetAssetAsync_003Ed__1))]
		public Task<Material> GetAssetAsync()
		{
			int num = 0;
			int num2 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<Material>)(object)result;
		}
	}
}
