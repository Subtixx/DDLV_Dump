using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Items;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200067D")]
	internal class RealmShortcutEnvironmentDoor : BaseEnvironmentDoor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002699")]
		[ItemID]
		[SerializeField]
		private int _sceneItem;

		[Cpp2IlInjected.Token(Token = "0x17000405")]
		public SceneItemData SceneItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001CD3")]
			[Cpp2IlInjected.Address(RVA = "0xCBB700", Offset = "0xCBA100", VA = "0x180CBB700")]
			get
			{
				//Discarded unreachable code: IL_0016
				int sceneItem = _sceneItem;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)sceneItem);
				SceneItemData result = default(SceneItemData);
				return result;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CD4")]
			[Cpp2IlInjected.Address(RVA = "0xCBB880", Offset = "0xCBA280", VA = "0x180CBB880")]
			set
			{
				//Discarded unreachable code: IL_000f
				int num = (_sceneItem = value.iD_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000406")]
		public ItemScript ItemScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001CD5")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CItemScript_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CD6")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			set
			{
				_003CItemScript_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000407")]
		public override Transform Entrance
		{
			[Cpp2IlInjected.Token(Token = "0x6001CD9")]
			[Cpp2IlInjected.Address(RVA = "0xCBB870", Offset = "0xCBA270", VA = "0x180CBB870", Slot = "5")]
			get
			{
				return base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000408")]
		public override Transform Exit
		{
			[Cpp2IlInjected.Token(Token = "0x6001CDA")]
			[Cpp2IlInjected.Address(RVA = "0xCBB870", Offset = "0xCBA270", VA = "0x180CBB870", Slot = "6")]
			get
			{
				return base.transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD7")]
		[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "10")]
		public override ItemScript GetItemScript()
		{
			return ItemScript;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD8")]
		[Cpp2IlInjected.Address(RVA = "0xCBB700", Offset = "0xCBA100", VA = "0x180CBB700", Slot = "4")]
		public override SceneItemData GetSceneItemData()
		{
			//Discarded unreachable code: IL_0016
			int sceneItem = _sceneItem;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			long num = Convert.ToInt64((uint)sceneItem);
			SceneItemData result = default(SceneItemData);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CDB")]
		[Cpp2IlInjected.Address(RVA = "0xCBB810", Offset = "0xCBA210", VA = "0x180CBB810", Slot = "8")]
		public override void OnExit()
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CDC")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public RealmShortcutEnvironmentDoor()
		{
		}
	}
}
