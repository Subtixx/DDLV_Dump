using System;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Items;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000648")]
	public class EnvironmentDoor : BaseEnvironmentDoor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002583")]
		[SerializeField]
		[ItemID]
		public int _sceneItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002584")]
		public Transform OverrideExit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002585")]
		[SerializeField]
		private AK.Wwise.Event sfxDoor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002586")]
		[SerializeField]
		private AK.Wwise.Event reverbSetRoomState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002587")]
		public Transform curseVfxPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002588")]
		public AssetReference curseVfxAddress;

		[Cpp2IlInjected.Token(Token = "0x170003F0")]
		public SceneItemData SceneItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001BFF")]
			[Cpp2IlInjected.Address(RVA = "0x1362170", Offset = "0x1360B70", VA = "0x181362170")]
			get
			{
				//Discarded unreachable code: IL_0016
				int sceneItem = _sceneItem;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)sceneItem);
				SceneItemData result = default(SceneItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C00")]
		[Cpp2IlInjected.Address(RVA = "0x1362170", Offset = "0x1360B70", VA = "0x181362170", Slot = "4")]
		public override SceneItemData GetSceneItemData()
		{
			//Discarded unreachable code: IL_0016
			int sceneItem = _sceneItem;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			long num = Convert.ToInt64((uint)sceneItem);
			SceneItemData result = default(SceneItemData);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C01")]
		[Cpp2IlInjected.Address(RVA = "0x1362280", Offset = "0x1360C80", VA = "0x181362280", Slot = "7")]
		public override void OnDoorTriggered()
		{
			AK.Wwise.Event @event = sfxDoor;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
			AK.Wwise.Event event2 = reverbSetRoomState;
			if (event2 != null)
			{
				GameObject gameObject2 = base.gameObject;
				uint num2 = event2.Post(gameObject2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001C02")]
		[Cpp2IlInjected.Address(RVA = "0x13620B0", Offset = "0x1360AB0", VA = "0x1813620B0", Slot = "9")]
		protected override Transform GetExitTransform()
		{
			//IL_0010: Expected O, but got I4
			Transform overrideExit = OverrideExit;
			int num = 0;
			if (!(overrideExit != (UnityEngine.Object)num))
			{
				return base.GetExitTransform();
			}
			return OverrideExit;
		}

		[Cpp2IlInjected.Token(Token = "0x6001C03")]
		[Cpp2IlInjected.Address(RVA = "0x1362130", Offset = "0x1360B30", VA = "0x181362130", Slot = "10")]
		public override ItemScript GetItemScript()
		{
			return GetComponent<ItemScript>();
		}

		[Cpp2IlInjected.Token(Token = "0x6001C04")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public EnvironmentDoor()
		{
		}
	}
}
