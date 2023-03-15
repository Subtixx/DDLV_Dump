using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Navigation;
using Mdl.Utils;
using Meta;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000475")]
	[RequiredAllNotNull]
	public class MiniEventMenu : TemplateMenu, IHasText, IHasSpriteURI, IHasProgress, IHasTimeSpan, IHasItemList, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400169E")]
		private MiniEventMenuParam _param = new MiniEventMenuParam();

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40016A0")]
		public UnityEvent OnDisplayRefresh;

		[Cpp2IlInjected.Token(Token = "0x170004BD")]
		public MiniEventMenuModel Model
		{
			[Cpp2IlInjected.Token(Token = "0x6001CC5")]
			[Cpp2IlInjected.Address(RVA = "0x975DE0", Offset = "0x9747E0", VA = "0x180975DE0")]
			[CompilerGenerated]
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001CC6")]
			[Cpp2IlInjected.Address(RVA = "0x9765B0", Offset = "0x974FB0", VA = "0x1809765B0")]
			[CompilerGenerated]
			set
			{
				_003CModel_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new MiniEventMenuModel
		{
			TextDict = (Dictionary<TextType, string>)(object)new Dictionary<TKey, TValue>(),
			ImageAddressDict = (Dictionary<SpriteType, string>)(object)new Dictionary<TKey, TValue>(),
			MilestoneModels = (List<MiniEventMilestoneModel>)(object)new List<T>()
		};


		[Cpp2IlInjected.Token(Token = "0x6001CC7")]
		[Cpp2IlInjected.Address(RVA = "0x1292020", Offset = "0x1290A20", VA = "0x181292020", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_0022
			base.OnPush(stack, param);
			if (param != null)
			{
				MiniEventMenuParam param2 = _param;
				object[] array = (param2.Params = param.Params);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC8")]
		[Cpp2IlInjected.Address(RVA = "0xE1A830", Offset = "0xE19230", VA = "0x180E1A830", Slot = "26")]
		public override void OnPop()
		{
			base.OnPop();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC9")]
		[Cpp2IlInjected.Address(RVA = "0x1291DE0", Offset = "0x12907E0", VA = "0x181291DE0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0061
			if (_param.MiniEventProgress != null)
			{
				MiniEventMenuParam param = _param;
				MiniEventMenuModel miniEventMenuModel = Model;
				MiniEventProgress miniEventProgress = (miniEventMenuModel.MiniEventProgress = param.MiniEventProgress);
				MiniEventMenuParam param2 = _param;
				MiniEventMenuModel miniEventMenuModel2 = Model;
				MiniEventData miniEventData = (miniEventMenuModel2.MiniEventData = param2.MiniEventProgress.Data);
			}
			Model.RefreshData();
			base.OnFocusIn();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CCA")]
		[Cpp2IlInjected.Address(RVA = "0x1291EB0", Offset = "0x12908B0", VA = "0x181291EB0", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			base.OnFocusOut(popAfterFocusOut, animate);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CCB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			((object)this)._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CCC")]
		[Cpp2IlInjected.Address(RVA = "0xE1AEF0", Offset = "0xE198F0", VA = "0x180E1AEF0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			base.UnregisterFocusedListeners();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CCD")]
		[Cpp2IlInjected.Address(RVA = "0x1292130", Offset = "0x1290B30", VA = "0x181292130")]
		public void RefreshData()
		{
			//Discarded unreachable code: IL_005b
			if (_param.MiniEventProgress != null)
			{
				MiniEventMenuParam param = _param;
				MiniEventMenuModel miniEventMenuModel = Model;
				MiniEventProgress miniEventProgress = (miniEventMenuModel.MiniEventProgress = param.MiniEventProgress);
				MiniEventMenuParam param2 = _param;
				MiniEventMenuModel miniEventMenuModel2 = Model;
				MiniEventData miniEventData = (miniEventMenuModel2.MiniEventData = param2.MiniEventProgress.Data);
			}
			Model.RefreshData();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CCE")]
		[Cpp2IlInjected.Address(RVA = "0x12921F0", Offset = "0x1290BF0", VA = "0x1812921F0")]
		public void RefreshDisplay()
		{
			OnDisplayRefresh?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CCF")]
		[Cpp2IlInjected.Address(RVA = "0x1291EC0", Offset = "0x12908C0", VA = "0x181291EC0")]
		public void OnMilestoneItemData(ListEventData args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD0")]
		[Cpp2IlInjected.Address(RVA = "0x1291C90", Offset = "0x1290690", VA = "0x181291C90")]
		public void OnCloseClicked()
		{
			//Discarded unreachable code: IL_0043
			int num = 0;
			MenuStack menuStack = UiRoot.Instance._menuStack;
			Type typeFromHandle = typeof(HudMenu);
			MenuStack._003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals0 = new MenuStack._003C_003Ec__DisplayClass25_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = menuStack;
			CS_0024_003C_003E8__locals0.menuType = typeFromHandle;
			Action action = delegate
			{
				//Discarded unreachable code: IL_0024
				MenuStack _003C_003E4__this = CS_0024_003C_003E8__locals0._003C_003E4__this;
				Type menuType = CS_0024_003C_003E8__locals0.menuType;
				Action onComplete = _003C_003E4__this.ExecuteNextAction;
				_003C_003E4__this.DoPopAllAbove(menuType, onComplete);
			};
			menuStack.QueueAction(action);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD1")]
		[Cpp2IlInjected.Address(RVA = "0x1292070", Offset = "0x1290A70", VA = "0x181292070")]
		public void OnShopButtonClicked()
		{
			//Discarded unreachable code: IL_003a
			//IL_001c: Expected I4, but got I8
			//IL_0039: Expected I4, but got I8
			//IL_0039: Expected I4, but got I8
			//IL_0039: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			ShopMenuParam shopMenuParam = new ShopMenuParam();
			shopMenuParam.ShopMenuTab = ShopMenu.ShopMenuTabs.Currency;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			ulong num5 = default(ulong);
			redirection.Redirect(RedirectionType.MenuShop, shopMenuParam, (PlayerTaskCollider)num3, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num4 != 0, (byte)num2 != 0, (byte)num5 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD2")]
		[Cpp2IlInjected.Address(RVA = "0x1291B20", Offset = "0x1290520", VA = "0x181291B20", Slot = "38")]
		public string GetText(TextType textType)
		{
			MiniEventMenuModel miniEventMenuModel = Model;
			string empty = string.Empty;
			if (miniEventMenuModel == null || miniEventMenuModel.TextDict != null)
			{
			}
			return empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD3")]
		[Cpp2IlInjected.Address(RVA = "0x1291AE0", Offset = "0x12904E0", VA = "0x181291AE0", Slot = "40")]
		public float GetProgress()
		{
			while (true)
			{
				MiniEventMenuModel miniEventMenuModel = Model;
				if (miniEventMenuModel != null)
				{
				}
				if (miniEventMenuModel != null)
				{
					/*Error: Could not find block for branch target IL_000f*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD4")]
		[Cpp2IlInjected.Address(RVA = "0x1291BB0", Offset = "0x12905B0", VA = "0x181291BB0", Slot = "41")]
		public TimeSpan GetTime()
		{
			//Discarded unreachable code: IL_000c
			return Model.TimeLeft;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD5")]
		[Cpp2IlInjected.Address(RVA = "0x1291BD0", Offset = "0x12905D0", VA = "0x181291BD0", Slot = "39")]
		public string GetURI(SpriteType spriteType)
		{
			MiniEventMenuModel miniEventMenuModel = Model;
			string empty = string.Empty;
			if (miniEventMenuModel == null || miniEventMenuModel.ImageAddressDict != null)
			{
			}
			return empty;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD6")]
		[Cpp2IlInjected.Address(RVA = "0x1291A50", Offset = "0x1290450", VA = "0x181291A50", Slot = "42")]
		public int GetLength()
		{
			MiniEventMenuModel miniEventMenuModel = Model;
			if (miniEventMenuModel != null)
			{
				List<MiniEventMilestoneModel> milestoneModels = miniEventMenuModel.MilestoneModels;
				if (milestoneModels != null)
				{
					int size = ((List<>)(object)milestoneModels)._size;
				}
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD7")]
		[Cpp2IlInjected.Address(RVA = "0x1291C60", Offset = "0x1290660", VA = "0x181291C60", Slot = "43")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			if (redirectionType == RedirectionType.GamePromptClose)
			{
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD8")]
		[Cpp2IlInjected.Address(RVA = "0x12918B0", Offset = "0x12902B0", VA = "0x1812918B0")]
		public void ClaimReward(MiniEventMilestoneItem miniEventMilestoneItem)
		{
			//Discarded unreachable code: IL_0010
			CancellationToken cancellationToken = base.CancellationToken;
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CD9")]
		[Cpp2IlInjected.Address(RVA = "0x1292210", Offset = "0x1290C10", VA = "0x181292210")]
		[AsyncStateMachine(typeof(_003CRequestClaimRewardTask_003Ed__24))]
		private Task RequestClaimRewardTask(MiniEventMilestoneModel model, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CDA")]
		[Cpp2IlInjected.Address(RVA = "0x1292350", Offset = "0x1290D50", VA = "0x181292350")]
		public MiniEventMenu()
		{
		}
	}
}
