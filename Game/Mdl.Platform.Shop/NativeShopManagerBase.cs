using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Gameloft.Common;
using Gameloft.Localization.Formatter;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x2000324")]
	public abstract class NativeShopManagerBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000325")]
		public class BackFromNativeStoreResult
		{
			[Cpp2IlInjected.Token(Token = "0x2000326")]
			public enum BuyStatus
			{
				[Cpp2IlInjected.Token(Token = "0x4001675")]
				Unknown,
				[Cpp2IlInjected.Token(Token = "0x4001676")]
				PurchaseWasMade,
				[Cpp2IlInjected.Token(Token = "0x4001677")]
				NoPurchaseWasMade
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001673")]
			public BuyStatus Status;

			[Cpp2IlInjected.Token(Token = "0x170001B7")]
			public bool ShouldTriggerRedeemFlow
			{
				[Cpp2IlInjected.Token(Token = "0x6000DAC")]
				[Cpp2IlInjected.Address(RVA = "0x1204670", Offset = "0x1203070", VA = "0x181204670")]
				get
				{
					return Status != BuyStatus.NoPurchaseWasMade;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000DAB")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public BackFromNativeStoreResult WithStatus(BuyStatus status)
			{
				Status = status;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000DAD")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public BackFromNativeStoreResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000327")]
		private static class Config
		{
			[Cpp2IlInjected.Token(Token = "0x4001678")]
			public static readonly bool PromptUserBeforeClaiming;

			[Cpp2IlInjected.Token(Token = "0x4001679")]
			public static readonly bool AutoClaim;
		}

		[Cpp2IlInjected.Token(Token = "0x4001671")]
		public static readonly string DefaultTaxDisclaimer = string.Empty;

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public abstract IEnumerable<NativeShopItemBase> AllShopItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000D9F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4001670")]
		public bool InitiateRedeemFlowOnBackFromNativeStore
		{
			[Cpp2IlInjected.Token(Token = "0x6000DA2")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000DA3")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4001672")]
		public virtual string TaxDisclaimer
		{
			[Cpp2IlInjected.Token(Token = "0x6000DA6")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public virtual string StoreName
		{
			[Cpp2IlInjected.Token(Token = "0x6000DA7")]
			[Cpp2IlInjected.Address(RVA = "0xF01740", Offset = "0xF00140", VA = "0x180F01740", Slot = "10")]
			get
			{
				//IL_0010: Expected O, but got I4
				//IL_0010: Expected O, but got I4
				int num = 0;
				int num2 = 0;
				return LocalizationManager.FromStringID("menu.shop_native_storename_generic", (IResolver)num2, (string)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D9E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract Task<InitializeShop.Result> RefreshCatalogAsync(InitializeShop.Request request, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6000DA0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "6")]
		public virtual void OnUIShopStatusChanged(bool opened)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract Task<OpenShopToBuyItem.Result> OpenShopToBuyItemAsync(OpenShopToBuyItem.Request request, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6000DA4")]
		[Cpp2IlInjected.Address(RVA = "0xF01200", Offset = "0xEFFC00", VA = "0x180F01200")]
		protected void HandleBackFromNativeShopResult(BackFromNativeStoreResult result)
		{
			//IL_0014: Expected O, but got I4
			bool shouldTriggerRedeemFlow = result.ShouldTriggerRedeemFlow;
			int num = 0;
			string text = $"HandleBackFromNativeShopResult(ShouldTriggerRedeemFlow={shouldTriggerRedeemFlow})";
			if (InitiateRedeemFlowOnBackFromNativeStore)
			{
				if (result.ShouldTriggerRedeemFlow)
				{
					int num2 = 0;
					int num3 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "8")]
		public virtual void DebugTraceDetailedInformation()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA8")]
		[Cpp2IlInjected.Address(RVA = "0xF016C0", Offset = "0xF000C0", VA = "0x180F016C0")]
		protected NativeShopManagerBase()
		{
			string text = (TaxDisclaimer = DefaultTaxDisclaimer);
			int opened = 0;
			OnUIShopStatusChanged((byte)opened != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000DA9")]
		[Cpp2IlInjected.Address(RVA = "0xF01660", Offset = "0xF00060", VA = "0x180F01660")]
		static NativeShopManagerBase()
		{
			/*Error: Unexpected end of block*/;
		}
	}
}
