using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Items;
using Mdl.Navigation;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000647")]
	public abstract class BaseEnvironmentDoor : MonoBehaviour, IPlayerTaskData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002582")]
		public string animationTrigger;

		[Cpp2IlInjected.Token(Token = "0x170003EE")]
		public virtual Transform Entrance
		{
			[Cpp2IlInjected.Token(Token = "0x6001BF8")]
			[Cpp2IlInjected.Address(RVA = "0x163AE20", Offset = "0x1639820", VA = "0x18163AE20", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_000c
				return GetComponent<PlayerTaskCollider>().Destination;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EF")]
		public virtual Transform Exit
		{
			[Cpp2IlInjected.Token(Token = "0x6001BF9")]
			[Cpp2IlInjected.Address(RVA = "0x13A1F60", Offset = "0x13A0960", VA = "0x1813A1F60", Slot = "6")]
			get
			{
				SceneItemData sceneItemData = GetSceneItemData();
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BF7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract SceneItemData GetSceneItemData();

		[Cpp2IlInjected.Token(Token = "0x6001BFA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "7")]
		public virtual void OnDoorTriggered()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001BFB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		public virtual void OnExit()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001BFC")]
		[Cpp2IlInjected.Address(RVA = "0x163ADD0", Offset = "0x16397D0", VA = "0x18163ADD0", Slot = "9")]
		protected virtual Transform GetExitTransform()
		{
			//Discarded unreachable code: IL_000c
			return GetComponent<PlayerTaskCollider>().Destination;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BFD")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract ItemScript GetItemScript();

		[Cpp2IlInjected.Token(Token = "0x6001BFE")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected BaseEnvironmentDoor()
		{
		}
	}
}
