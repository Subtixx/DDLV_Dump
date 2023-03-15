using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000C45")]
	public class FastTravelDestination : MonoBehaviour, IPlayerTaskData, IPlayerTaskProvider
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004489")]
		[SerializeField]
		private PlayerTaskDefinition _useFastTravelTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400448A")]
		public Transform Destination;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400448C")]
		private ItemScript itemScript;

		[Cpp2IlInjected.Token(Token = "0x17000789")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600384B")]
			[Cpp2IlInjected.Address(RVA = "0x136D7A0", Offset = "0x136C1A0", VA = "0x18136D7A0")]
			get
			{
				//IL_0010: Expected O, but got I4
				//IL_0031: Expected O, but got I4
				GridScript gridScript = GridScript;
				int num = 0;
				if (!(gridScript != (UnityEngine.Object)num) || !GridScript.Locked)
				{
					ItemScript itemScript = this.itemScript;
					int num2 = 0;
					if (!(itemScript == (UnityEngine.Object)num2))
					{
						Profile profile = SystemRoot.Instance.MetaClient.profile;
						ItemScript itemScript2 = this.itemScript;
						ProfileWorld world_ = profile.world_;
						Item item = itemScript2.Item;
						bool flag = default(bool);
						if (flag)
						{
							return true;
						}
					}
				}
				int num3 = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700078A")]
		public GridScript GridScript
		{
			[Cpp2IlInjected.Token(Token = "0x600384C")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			[CompilerGenerated]
			get
			{
				return _003CGridScript_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x600384D")]
			[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
			[CompilerGenerated]
			private set
			{
				_003CGridScript_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700078B")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x600384E")]
			[Cpp2IlInjected.Address(RVA = "0x136D780", Offset = "0x136C180", VA = "0x18136D780")]
			get
			{
				//Discarded unreachable code: IL_000c
				return itemScript.Item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600384F")]
		[Cpp2IlInjected.Address(RVA = "0x136D700", Offset = "0x136C100", VA = "0x18136D700")]
		private void Start()
		{
			ItemScript itemScript = (this.itemScript = GetComponent<ItemScript>());
			GridScript gridScript = (GridScript = GetComponentInParent<GridScript>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003850")]
		[Cpp2IlInjected.Address(RVA = "0x136D690", Offset = "0x136C090", VA = "0x18136D690", Slot = "4")]
		[IteratorStateMachine(typeof(_003CMdl_002DNavigation_002DIPlayerTaskProvider_002DGetTasks_003Ed__12))]
		IEnumerable<PlayerTaskDefinition> IPlayerTaskProvider.GetTasks()
		{
			new _003CMdl_002DNavigation_002DIPlayerTaskProvider_002DGetTasks_003Ed__12(-2)._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003851")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public FastTravelDestination()
		{
		}
	}
}
