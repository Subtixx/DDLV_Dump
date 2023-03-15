using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Avatar;
using Mdl.Buildings;
using Mdl.Items;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x2000691")]
	internal class StoreShowcase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000692")]
		private enum RefreshType
		{
			[Cpp2IlInjected.Token(Token = "0x40026F2")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40026F3")]
			RequiredOnly,
			[Cpp2IlInjected.Token(Token = "0x40026F4")]
			All
		}

		[Cpp2IlInjected.Token(Token = "0x2000693")]
		private class ShowcaseDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x17000410")]
			public Mdl.Buildings.Display VisualDisplay
			{
				[Cpp2IlInjected.Token(Token = "0x6001D24")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CVisualDisplay_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6001D25")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CVisualDisplay_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000411")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x40026F6")]
			public int DisplayIndex
			{
				[Cpp2IlInjected.Token(Token = "0x6001D26")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6001D27")]
				[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000412")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x40026F7")]
			public bool RefreshNeeded
			{
				[Cpp2IlInjected.Token(Token = "0x6001D28")]
				[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6001D29")]
				[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6001D2A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ShowcaseDisplay()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40026E8")]
		[SerializeField]
		private List<Mdl.Buildings.Display> displays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40026E9")]
		[SerializeField]
		private float itemScaleFactorFemale = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40026EA")]
		[SerializeField]
		private float itemScaleFactorMale = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40026EB")]
		[SerializeField]
		private StoreConfig storeConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40026ED")]
		private RefreshType refreshTypeRequired;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40026EE")]
		private List<ShowcaseDisplay> showcaseDisplays = (List<ShowcaseDisplay>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40026EF")]
		private bool lastAvatarLoadedIsMale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40026F0")]
		private CancellationTokenSource ctsAutoRefresh = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x1700040D")]
		public ItemScript ItemScript
		{
			[Cpp2IlInjected.Token(Token = "0x6001D11")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CItemScript_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001D12")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CItemScript_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040E")]
		private Profile profile
		{
			[Cpp2IlInjected.Token(Token = "0x6001D13")]
			[Cpp2IlInjected.Address(RVA = "0x105EA70", Offset = "0x105D470", VA = "0x18105EA70")]
			get
			{
				//Discarded unreachable code: IL_0015
				return SystemRoot.Instance.Client.MetaClient.profile;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700040F")]
		private bool IsAvatarMale
		{
			[Cpp2IlInjected.Token(Token = "0x6001D14")]
			[Cpp2IlInjected.Address(RVA = "0x105E9B0", Offset = "0x105D3B0", VA = "0x18105E9B0")]
			get
			{
				//Discarded unreachable code: IL_0015
				return SystemRoot.Instance._avatar.appearance.IsMale;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D15")]
		[Cpp2IlInjected.Address(RVA = "0x105E2B0", Offset = "0x105CCB0", VA = "0x18105E2B0")]
		protected void Start()
		{
			//Discarded unreachable code: IL_0083
			ItemScript itemScript = (ItemScript = GetComponentInParent<ItemScript>());
			bool flag = (lastAvatarLoadedIsMale = SystemRoot.Instance._avatar.appearance.IsMale);
			WaitForNextAutoRefresh(onStart: true);
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.Client.MetaClient.Dispatcher;
			ProfileEventDispatcher.StoreItemBought value = OnStoreItemBought;
			_003CDispatcher_003Ek__BackingField.OnStoreItemBought += value;
			AvatarAppearance appearance = SystemRoot.Instance._avatar.appearance;
			AvatarAppearance.AvatarChanged value2 = OnAvatarChanged;
			appearance.OnAvatarChanged += value2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D16")]
		[Cpp2IlInjected.Address(RVA = "0x105DAE0", Offset = "0x105C4E0", VA = "0x18105DAE0")]
		protected void OnDestroy()
		{
			//Discarded unreachable code: IL_00b8
			//IL_000f: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			//IL_00b7: Expected O, but got I8
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				Mdl.Online.Client client = SystemRoot.Instance.Client;
				if ((object)client != null)
				{
					Meta.Online.Client _003CMetaClient_003Ek__BackingField = client.MetaClient;
					if (_003CMetaClient_003Ek__BackingField != null && (long)_003CMetaClient_003Ek__BackingField.Dispatcher != 0)
					{
						Mdl.Online.Client client2 = default(Mdl.Online.Client);
						ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client2.MetaClient.Dispatcher;
						ProfileEventDispatcher.StoreItemBought value = OnStoreItemBought;
						_003CDispatcher_003Ek__BackingField.OnStoreItemBought -= value;
					}
				}
				if ((object)SystemRoot.Instance._avatar != null)
				{
				}
				int num2 = 0;
				int num3 = 0;
				if ((UnityEngine.Object)num2 != (UnityEngine.Object)num3)
				{
					int num4 = 0;
					AvatarAppearance.AvatarChanged avatarChanged = OnAvatarChanged;
				}
			}
			CancellationTokenSource cancellationTokenSource = ctsAutoRefresh;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				ctsAutoRefresh.Dispose();
				ctsAutoRefresh = (CancellationTokenSource)0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D17")]
		[Cpp2IlInjected.Address(RVA = "0x105DEB0", Offset = "0x105C8B0", VA = "0x18105DEB0")]
		public void OnEnable()
		{
			RefreshType refreshType = refreshTypeRequired;
			if (refreshType != RefreshType.RequiredOnly && refreshType == RefreshType.All)
			{
				FireTaskRefreshAllShowcase();
			}
			else
			{
				FireTaskRefreshShowcase();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D18")]
		[Cpp2IlInjected.Address(RVA = "0x105D8C0", Offset = "0x105C2C0", VA = "0x18105D8C0")]
		private StoreInfo GetProfileStore()
		{
			//IL_0010: Expected O, but got I4
			ItemScript itemScript = ItemScript;
			int num = 0;
			if (itemScript != (UnityEngine.Object)num)
			{
				Item item = ItemScript.Item;
				bool flag = default(bool);
				if (flag)
				{
					ProfileWorld world_ = SystemRoot.Instance.Client.MetaClient.profile.world_;
					Item item2 = ItemScript.Item;
					StoreInfo result = default(StoreInfo);
					return result;
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D19")]
		[Cpp2IlInjected.Address(RVA = "0x105DED0", Offset = "0x105C8D0", VA = "0x18105DED0")]
		private void OnStoreItemBought(Item building, Item item, int displayIdx)
		{
			//Discarded unreachable code: IL_005e
			//IL_0056: Expected I4, but got I8
			ItemScript itemScript = ItemScript;
			int num = default(int);
			if (num == 0)
			{
				return;
			}
			List<ShowcaseDisplay> list = showcaseDisplays;
			Func<ShowcaseDisplay, bool> func = (Func<ShowcaseDisplay, bool>)(object)(Func<T, TResult>)delegate(ShowcaseDisplay x)
			{
				//Discarded unreachable code: IL_0011
				int num2 = displayIdx;
				return x.DisplayIndex == num2;
			};
			ShowcaseDisplay showcaseDisplay = Enumerable.FirstOrDefault<ShowcaseDisplay>((IEnumerable<>)list, (Func<, >)(object)func);
			if (showcaseDisplay != null)
			{
				showcaseDisplay.RefreshNeeded = true;
				if (!base.isActiveAndEnabled)
				{
					refreshTypeRequired = RefreshType.RequiredOnly;
				}
				else
				{
					FireTaskRefreshShowcase();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1A")]
		[Cpp2IlInjected.Address(RVA = "0x105DA90", Offset = "0x105C490", VA = "0x18105DA90")]
		private void OnAvatarChanged(AvatarAppearance avatar)
		{
			//Discarded unreachable code: IL_0031
			//IL_0029: Expected I4, but got I8
			bool _003CIsMale_003Ek__BackingField = avatar.IsMale;
			if (_003CIsMale_003Ek__BackingField != lastAvatarLoadedIsMale)
			{
				lastAvatarLoadedIsMale = _003CIsMale_003Ek__BackingField;
				if (!base.isActiveAndEnabled)
				{
					refreshTypeRequired = RefreshType.All;
				}
				else
				{
					FireTaskRefreshAllShowcase();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1B")]
		[Cpp2IlInjected.Address(RVA = "0x105E150", Offset = "0x105CB50", VA = "0x18105E150")]
		private void RefreshAllShowcase()
		{
			//IL_0012: Expected I4, but got I8
			if (!base.isActiveAndEnabled)
			{
				refreshTypeRequired = RefreshType.All;
			}
			else
			{
				FireTaskRefreshAllShowcase();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1C")]
		[Cpp2IlInjected.Address(RVA = "0x105D740", Offset = "0x105C140", VA = "0x18105D740")]
		private void FireTaskRefreshShowcase()
		{
			StoreInfo profileStore = GetProfileStore();
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1D")]
		[Cpp2IlInjected.Address(RVA = "0x105E180", Offset = "0x105CB80", VA = "0x18105E180")]
		[AsyncStateMachine(typeof(_003CRefreshShowcaseAsync_003Ed__26))]
		private Task RefreshShowcaseAsync(StoreInfo storeInfo)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1E")]
		[Cpp2IlInjected.Address(RVA = "0x105D600", Offset = "0x105C000", VA = "0x18105D600")]
		private void FireTaskRefreshAllShowcase()
		{
			int num = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D1F")]
		[Cpp2IlInjected.Address(RVA = "0x105E050", Offset = "0x105CA50", VA = "0x18105E050")]
		[AsyncStateMachine(typeof(_003CRefreshAllShowcaseAsync_003Ed__28))]
		private Task RefreshAllShowcaseAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D20")]
		[Cpp2IlInjected.Address(RVA = "0x105E590", Offset = "0x105CF90", VA = "0x18105E590")]
		private void WaitForNextAutoRefresh(bool onStart = false)
		{
			//Discarded unreachable code: IL_004b
			//IL_0025: Expected O, but got I8
			CancellationTokenSource cancellationTokenSource = ctsAutoRefresh;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				ctsAutoRefresh.Dispose();
				ctsAutoRefresh = (CancellationTokenSource)0;
			}
			CancellationTokenSource cancellationTokenSource2 = (ctsAutoRefresh = new CancellationTokenSource());
			CancellationToken token = ctsAutoRefresh.Token;
			int num = 0;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001D21")]
		[Cpp2IlInjected.Address(RVA = "0x105D5B0", Offset = "0x105BFB0", VA = "0x18105D5B0")]
		private void CancelAutoRefresh()
		{
			//Discarded unreachable code: IL_0018
			CancellationTokenSource cancellationTokenSource = ctsAutoRefresh;
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
				cancellationTokenSource.Dispose();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001D22")]
		[Cpp2IlInjected.Address(RVA = "0x105E7B0", Offset = "0x105D1B0", VA = "0x18105E7B0")]
		[AsyncStateMachine(typeof(_003CWaitForNextAutoRefresh_003Ed__31))]
		private Task WaitForNextAutoRefresh(bool onStart, CancellationToken ct)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001D23")]
		[Cpp2IlInjected.Address(RVA = "0x105E8F0", Offset = "0x105D2F0", VA = "0x18105E8F0")]
		public StoreShowcase()
		{
		}
	}
}
