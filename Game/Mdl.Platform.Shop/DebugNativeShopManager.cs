using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using glPlayFab.Disney;
using PlayFab.EconomyModels;
using UnityEngine;

namespace Mdl.Platform.Shop
{
	[Cpp2IlInjected.Token(Token = "0x2000313")]
	public class DebugNativeShopManager : NativeShopManagerBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000314")]
		public class DebugNativeShopItem : NativeShopItemBase
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4001650")]
			public CatalogItem PlayfabCatalogItemBundle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4001651")]
			public IAPData MatchingIAPData;

			[Cpp2IlInjected.Token(Token = "0x170001A0")]
			public string DebugName
			{
				[Cpp2IlInjected.Token(Token = "0x6000D70")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CDebugName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000D71")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CDebugName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001A1")]
			public string DebugFormattedPrice
			{
				[Cpp2IlInjected.Token(Token = "0x6000D72")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CDebugFormattedPrice_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000D73")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CDebugFormattedPrice_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001A2")]
			public override bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x6000D74")]
				[Cpp2IlInjected.Address(RVA = "0x11960C0", Offset = "0x1194AC0", VA = "0x1811960C0", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001A3")]
			public override string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000D75")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "5")]
				get
				{
					return DebugName;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001A4")]
			public override string FormattedPrice
			{
				[Cpp2IlInjected.Token(Token = "0x6000D76")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0", Slot = "6")]
				get
				{
					return DebugFormattedPrice;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001A5")]
			public override string Description
			{
				[Cpp2IlInjected.Token(Token = "0x6000D77")]
				[Cpp2IlInjected.Address(RVA = "0x1196020", Offset = "0x1194A20", VA = "0x181196020", Slot = "8")]
				get
				{
					return string.Empty;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001A6")]
			public override string NativeItemID
			{
				[Cpp2IlInjected.Token(Token = "0x6000D78")]
				[Cpp2IlInjected.Address(RVA = "0x11960D0", Offset = "0x1194AD0", VA = "0x1811960D0", Slot = "7")]
				get
				{
					IAPData matchingIAPData = MatchingIAPData;
					if (matchingIAPData == null || matchingIAPData.AnyNativeID == null)
					{
					}
					return "InvalidMatchingIAP";
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001A7")]
			public static string CurrentStoreGroupPostFix
			{
				[Cpp2IlInjected.Token(Token = "0x6000D79")]
				[Cpp2IlInjected.Address(RVA = "0x1195F50", Offset = "0x1194950", VA = "0x181195F50")]
				get
				{
					StoreFrontGroup _003CCurrentStoreFrontGroup_003Ek__BackingField;
					do
					{
						_003CCurrentStoreFrontGroup_003Ek__BackingField = StoreFrontGroup.CurrentStoreFrontGroup;
					}
					while (_003CCurrentStoreFrontGroup_003Ek__BackingField != null && _003CCurrentStoreFrontGroup_003Ek__BackingField.uniqueName_ != null);
					return string.Empty;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001A8")]
			public bool IsFromCurrentStoreFront
			{
				[Cpp2IlInjected.Token(Token = "0x6000D7A")]
				[Cpp2IlInjected.Address(RVA = "0x1196060", Offset = "0x1194A60", VA = "0x181196060")]
				get
				{
					if (!string.IsNullOrEmpty(DebugName))
					{
						int num = 0;
						if (!string.IsNullOrEmpty(CurrentStoreGroupPostFix))
						{
							string text = DebugName;
							int num2 = 0;
							string currentStoreGroupPostFix = CurrentStoreGroupPostFix;
							return text.EndsWith(currentStoreGroupPostFix);
						}
					}
					int num3 = 0;
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000D7B")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public DebugNativeShopItem()
			{
				((glPlayFab.Disney.BattlePassReward)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400164F")]
		private List<DebugNativeShopItem> DebugNativeShopItems = (List<DebugNativeShopItem>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		public AK.Wwise.Event ConfirmSFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000D67")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CConfirmSFX_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000D68")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CConfirmSFX_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public override IEnumerable<NativeShopItemBase> AllShopItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000D69")]
			[Cpp2IlInjected.Address(RVA = "0x161B210", Offset = "0x1619C10", VA = "0x18161B210", Slot = "5")]
			get
			{
				List<DebugNativeShopItem> debugNativeShopItems = DebugNativeShopItems;
				Func<DebugNativeShopItem, bool> _003C_003E9__7_ = _003C_003Ec._003C_003E9__7_0;
				if (_003C_003E9__7_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(DebugNativeShopItem x)
					{
						string _003CDebugName_003Ek__BackingField = x.DebugName;
						int num = 0;
						if (DebugNativeShopItem.CurrentStoreGroupPostFix == null)
						{
							string _003CDebugName_003Ek__BackingField2 = x.DebugName;
							int num2 = 0;
							string currentStoreGroupPostFix = DebugNativeShopItem.CurrentStoreGroupPostFix;
							return _003CDebugName_003Ek__BackingField2.EndsWith(currentStoreGroupPostFix);
						}
						int num3 = 0;
						throw new NullReferenceException();
					};
				}
				IEnumerable<DebugNativeShopItem> enumerable = (IEnumerable<DebugNativeShopItem>)Enumerable.Where<DebugNativeShopItem>((IEnumerable<>)debugNativeShopItems, (Func<, >)(object)_003C_003E9__7_);
				Func<DebugNativeShopItem, NativeShopItemBase> func = default(Func<DebugNativeShopItem, NativeShopItemBase>);
				if (_003C_003Ec._003C_003E9__7_1 == null)
				{
					func = (Func<DebugNativeShopItem, NativeShopItemBase>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					});
				}
				return (IEnumerable<NativeShopItemBase>)Enumerable.Select<DebugNativeShopItem, NativeShopItemBase>((IEnumerable<>)enumerable, (Func<, >)(object)func);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6A")]
		[Cpp2IlInjected.Address(RVA = "0x161B050", Offset = "0x1619A50", VA = "0x18161B050", Slot = "4")]
		[AsyncStateMachine(typeof(_003CRefreshCatalogAsync_003Ed__8))]
		public override Task<InitializeShop.Result> RefreshCatalogAsync(InitializeShop.Request request, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<InitializeShop.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6B")]
		[Cpp2IlInjected.Address(RVA = "0x161AF30", Offset = "0x1619930", VA = "0x18161AF30", Slot = "7")]
		[AsyncStateMachine(typeof(_003COpenShopToBuyItemAsync_003Ed__9))]
		public override Task<OpenShopToBuyItem.Result> OpenShopToBuyItemAsync(OpenShopToBuyItem.Request request, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<OpenShopToBuyItem.Result>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6C")]
		[Cpp2IlInjected.Address(RVA = "0x161AE40", Offset = "0x1619840", VA = "0x18161AE40")]
		[AsyncStateMachine(typeof(_003CEnsureStoreFrontGroupSet_003Ed__10))]
		private Task<bool> EnsureStoreFrontGroupSet()
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6D")]
		[Cpp2IlInjected.Address(RVA = "0x161AD70", Offset = "0x1619770", VA = "0x18161AD70")]
		[AsyncStateMachine(typeof(_003CEnsureEmbedPortal_003Ed__11))]
		private Task EnsureEmbedPortal()
		{
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6E")]
		[Cpp2IlInjected.Address(RVA = "0x161A4E0", Offset = "0x1618EE0", VA = "0x18161A4E0", Slot = "8")]
		public override void DebugTraceDetailedInformation()
		{
			//Discarded unreachable code: IL_017b, IL_0183, IL_018e, IL_01a1, IL_01a9, IL_01af, IL_01b7, IL_01bf, IL_01d1, IL_01d5, IL_01dd, IL_01e3, IL_0234, IL_023a, IL_0240
			//IL_0015: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num = 0;
				if (StoreFrontGroup.CurrentStoreFrontGroup != null)
				{
				}
				Debug.Log("[DebugNativeShopItem] - DebugTraceDetailedInformation (current Store=" + (string)num);
				List<DebugNativeShopItem> debugNativeShopItems = DebugNativeShopItems;
				if (flag)
				{
					if (!flag)
					{
					}
					string[] array = new string[14];
					if ("DebugNativeShopItem " == null || "DebugNativeShopItem " != null)
					{
						array[0] = "DebugNativeShopItem ";
						if ("DebugNativeShopItem " == null || "DebugNativeShopItem " != null)
						{
							array[1] = "DebugNativeShopItem ";
							if (":" == null || ":" != null)
							{
								array[2] = ":";
								string text = $"\n\tIsFromCurrentStoreFront={flag2}";
								if (text == null || text != null)
								{
									array[3] = text;
									if ("\n\tFormattedPrice=" == null || "\n\tFormattedPrice=" != null)
									{
										array[4] = "\n\tFormattedPrice=";
										if ("\n\tFormattedPrice=" == null || "\n\tFormattedPrice=" != null)
										{
											array[5] = "\n\tFormattedPrice=";
											if ("\n\tNativeItemID=" == null || "\n\tNativeItemID=" != null)
											{
												array[6] = "\n\tNativeItemID=";
												if ("\n\tNativeItemID=" == null || "\n\tNativeItemID=" != null)
												{
													array[7] = "\n\tNativeItemID=";
													if ("\n\tMatchingIAPData.UniqueName=" == null || "\n\tMatchingIAPData.UniqueName=" != null)
													{
														array[8] = "\n\tMatchingIAPData.UniqueName=";
														if ("\n\tNativeItemID=" != null && "\n\tNativeItemID=" != null && "\n\tMatchingIAPData.UniqueName=" == null)
														{
															break;
														}
														throw new IndexOutOfRangeException();
													}
													throw new IndexOutOfRangeException();
												}
												throw new IndexOutOfRangeException();
											}
											throw new IndexOutOfRangeException();
										}
										throw new IndexOutOfRangeException();
									}
									throw new IndexOutOfRangeException();
								}
								throw new IndexOutOfRangeException();
							}
							throw new IndexOutOfRangeException();
						}
						throw new IndexOutOfRangeException();
					}
					throw new IndexOutOfRangeException();
				}
				if (!flag2)
				{
					return;
				}
			}
			throw new IndexOutOfRangeException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000D6F")]
		[Cpp2IlInjected.Address(RVA = "0x161B170", Offset = "0x1619B70", VA = "0x18161B170")]
		public DebugNativeShopManager()
		{
		}
	}
}
