using System;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Environments;
using Mdl.Systems;
using Mdl.Utils;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ftue.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000612")]
	[CreateAssetMenu]
	public class CurrentSceneIs : FtueCondition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002493")]
		[ItemID]
		[SerializeField]
		private int _SceneItem;

		[Cpp2IlInjected.Token(Token = "0x170003D3")]
		public SceneItemData SceneItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001AE9")]
			[Cpp2IlInjected.Address(RVA = "0x110A970", Offset = "0x1109370", VA = "0x18110A970")]
			get
			{
				//Discarded unreachable code: IL_0016
				int sceneItem = _SceneItem;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)sceneItem);
				SceneItemData result = default(SceneItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AEA")]
		[Cpp2IlInjected.Address(RVA = "0x110A6F0", Offset = "0x11090F0", VA = "0x18110A6F0", Slot = "4")]
		protected override void _Init(Client client)
		{
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= OnEnvironmentEntered;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += OnEnvironmentEntered;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AEB")]
		[Cpp2IlInjected.Address(RVA = "0x8B3070", Offset = "0x8B1A70", VA = "0x1808B3070")]
		private void OnEnvironmentEntered(object sender, EventArgs e)
		{
			if (IsTrue())
			{
				RaiseBecameTrue();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001AEC")]
		[Cpp2IlInjected.Address(RVA = "0x110A790", Offset = "0x1109190", VA = "0x18110A790", Slot = "5")]
		protected override bool _IsTrue()
		{
			//Discarded unreachable code: IL_0023
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			int sceneItem = _SceneItem;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			long num = Convert.ToInt64((uint)sceneItem);
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AED")]
		[Cpp2IlInjected.Address(RVA = "0x110A680", Offset = "0x1109080", VA = "0x18110A680", Slot = "6")]
		protected override void _CleanUp()
		{
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= OnEnvironmentEntered;
		}

		[Cpp2IlInjected.Token(Token = "0x6001AEE")]
		[Cpp2IlInjected.Address(RVA = "0x8B32A0", Offset = "0x8B1CA0", VA = "0x1808B32A0")]
		public CurrentSceneIs()
		{
		}
	}
}
