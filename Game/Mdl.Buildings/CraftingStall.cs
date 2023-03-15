using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Online;
using NodeCanvas.Framework;
using ScreenEffect;
using UnityEngine;

namespace Mdl.Buildings
{
	[Cpp2IlInjected.Token(Token = "0x2000998")]
	public class CraftingStall : Stall, IHighlightRendererOverride
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40034FE")]
		public GameObject CraftVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40034FF")]
		private GameObject craftVFXInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4003500")]
		private Toolbox.TemporarySwitchToolScope temporarySwitchToolScope;

		[Cpp2IlInjected.Token(Token = "0x6002CCE")]
		[Cpp2IlInjected.Address(RVA = "0x10FF600", Offset = "0x10FE000", VA = "0x1810FF600", Slot = "4")]
		protected override void Start()
		{
			//Discarded unreachable code: IL_004f
			base.Start();
			PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
			Mdl.Systems.System.SystemEvent value = OnPlayerNavigationStatusChanged;
			system.SystemPausedEvent += value;
			Mdl.Systems.System.SystemEvent value2 = OnPlayerNavigationStatusChanged;
			system.SystemResumedEvent += value2;
			bool flag = default(bool);
			bool flag2 = default(bool);
			if (flag && flag2)
			{
				bool flag3 = !system.IsPaused;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CCF")]
		[Cpp2IlInjected.Address(RVA = "0x10FF250", Offset = "0x10FDC50", VA = "0x1810FF250", Slot = "5")]
		protected override void OnDestroy()
		{
			//Discarded unreachable code: IL_0042
			//IL_001c: Expected O, but got I4
			//IL_001c: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				PlayerNavigation system = _003CInstance_003Ek__BackingField.GetSystem<PlayerNavigation>();
			}
			int num = 0;
			int num2 = 0;
			if ((UnityEngine.Object)num != (UnityEngine.Object)num2)
			{
				Mdl.Systems.System.SystemEvent systemEvent = OnPlayerNavigationStatusChanged;
				Mdl.Systems.System.SystemEvent systemEvent2 = OnPlayerNavigationStatusChanged;
			}
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD0")]
		[Cpp2IlInjected.Address(RVA = "0x10FF1E0", Offset = "0x10FDBE0", VA = "0x1810FF1E0", Slot = "11")]
		public void GetRenderers(List<Renderer> renderers)
		{
			//Discarded unreachable code: IL_0012
			((Component)base.transform.parent).GetComponentsInChildren<Renderer>((List<>)(object)renderers);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD1")]
		[Cpp2IlInjected.Address(RVA = "0x10FF090", Offset = "0x10FDA90", VA = "0x1810FF090", Slot = "8")]
		protected override void CustomSetup(bool startInteraction)
		{
			//IL_0017: Expected O, but got I4
			int targetIndex = 0;
			((Connection)(object)this).OnCreate(startInteraction ? 1 : 0, targetIndex);
			if (!startInteraction)
			{
				int num = 0;
				temporarySwitchToolScope = (Toolbox.TemporarySwitchToolScope)num;
				return;
			}
			Toolbox _003CToolbox_003Ek__BackingField = SystemRoot.Instance._avatar.Toolbox;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD2")]
		[Cpp2IlInjected.Address(RVA = "0x10FEF70", Offset = "0x10FD970", VA = "0x1810FEF70")]
		public Task<CraftWithRecipe.Types.Response> Craft(Item craftingRecipeItem, int amountToCraft, CancellationToken _)
		{
			//Discarded unreachable code: IL_0031
			//IL_0030: Expected O, but got I4
			int itemID = craftingRecipeItem.ItemID;
			Client metaClient = SystemRoot.Instance.MetaClient;
			CraftWithRecipe.Types.Request request = new CraftWithRecipe.Types.Request();
			request.craftingRecipeItemID_ = itemID;
			request.amountOfCrafting_ = amountToCraft;
			int num = 0;
			return (Task<CraftWithRecipe.Types.Response>)(object)metaClient.CraftWithRecipe(request, (CancellationToken)num);
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD3")]
		[Cpp2IlInjected.Address(RVA = "0x10FF490", Offset = "0x10FDE90", VA = "0x1810FF490")]
		public void StartCraftVFX()
		{
			//IL_0014: Expected O, but got I4
			bool flag = default(bool);
			if (flag)
			{
			}
			GameObject craftVFXPrefab = CraftVFXPrefab;
			int num = 0;
			if (craftVFXPrefab != (UnityEngine.Object)num)
			{
				GameObject craftVFXPrefab2 = CraftVFXPrefab;
				Transform parent = base.transform;
				GameObject gameObject = (craftVFXInstance = UnityEngine.Object.Instantiate(craftVFXPrefab2, parent));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD4")]
		[Cpp2IlInjected.Address(RVA = "0x10FF7E0", Offset = "0x10FE1E0", VA = "0x1810FF7E0")]
		public void StopCraftVFX()
		{
			//IL_0010: Expected O, but got I4
			//IL_0027: Expected O, but got I8
			GameObject gameObject = craftVFXInstance;
			int num = 0;
			if (gameObject != (UnityEngine.Object)num)
			{
				UnityEngine.Object.Destroy(craftVFXInstance);
				craftVFXInstance = (GameObject)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD5")]
		[Cpp2IlInjected.Address(RVA = "0x10FF400", Offset = "0x10FDE00", VA = "0x1810FF400")]
		private void OnPlayerNavigationStatusChanged(Mdl.Systems.System system)
		{
			//Discarded unreachable code: IL_000f
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = !system.IsPaused;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002CD6")]
		[Cpp2IlInjected.Address(RVA = "0x10FF8A0", Offset = "0x10FE2A0", VA = "0x1810FF8A0")]
		public CraftingStall()
		{
		}
	}
}
