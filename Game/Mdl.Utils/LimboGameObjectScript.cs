using Cpp2IlInjected;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000771")]
	public class LimboGameObjectScript : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6002106")]
		[Cpp2IlInjected.Address(RVA = "0xBB5140", Offset = "0xBB3B40", VA = "0x180BB5140")]
		private void Start()
		{
			//Discarded unreachable code: IL_001a
			CurseSystem system = SystemRoot.Instance.GetSystem<CurseSystem>();
			GameObject gameObject = base.gameObject;
			system.AddLimboGameObject(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6002107")]
		[Cpp2IlInjected.Address(RVA = "0xBB5050", Offset = "0xBB3A50", VA = "0x180BB5050")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_0021
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				CurseSystem system = _003CInstance_003Ek__BackingField.GetSystem<CurseSystem>();
				GameObject gameObject = base.gameObject;
				bool flag = system.RemoveLimboGameObject(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002108")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public LimboGameObjectScript()
		{
		}
	}
}
