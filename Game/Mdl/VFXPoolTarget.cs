using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl
{
	[Cpp2IlInjected.Token(Token = "0x2000216")]
	public class VFXPoolTarget : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40011BD")]
		[SerializeField]
		private GameObject prefab;

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xD41880", Offset = "0xD40280", VA = "0x180D41880")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_0027
			VFXPoolSystem system = SystemRoot.Instance.GetSystem<VFXPoolSystem>();
			GameObject gameObject = prefab;
			Transform parent = base.gameObject.transform;
			system.RequestEffect(gameObject, parent);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xD41780", Offset = "0xD40180", VA = "0x180D41780")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_001f
			VFXPoolSystem system = SystemRoot.Instance.GetSystem<VFXPoolSystem>();
			Transform parent = base.gameObject.transform;
			system.EndEffects(parent);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xD41780", Offset = "0xD40180", VA = "0x180D41780")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_001f
			VFXPoolSystem system = SystemRoot.Instance.GetSystem<VFXPoolSystem>();
			Transform parent = base.gameObject.transform;
			system.EndEffects(parent);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public VFXPoolTarget()
		{
		}
	}
}
