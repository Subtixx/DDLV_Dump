using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using Definitions.Activities;
using Definitions.Items;
using Mdl.Characters;
using Mdl.Characters.Critters;
using Mdl.Motion;
using Mdl.Navigation;
using Meta;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000225")]
	public class BaseUiRoot : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000226")]
		public delegate void MenuChanged(string menuName);

		[Cpp2IlInjected.Token(Token = "0x2000227")]
		public delegate void MenuSection(string menuSectionName);

		[Cpp2IlInjected.Token(Token = "0x2000228")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40012F1")]
			private readonly Action stop;

			[Cpp2IlInjected.Token(Token = "0x600097C")]
			[Cpp2IlInjected.Address(RVA = "0x10D4470", Offset = "0x10D2E70", VA = "0x1810D4470")]
			public Scope(Action start, Action stop)
			{
				start?.Invoke();
				this.stop = stop;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x600097D")]
			[Cpp2IlInjected.Address(RVA = "0x10D4460", Offset = "0x10D2E60", VA = "0x1810D4460", Slot = "4")]
			public void Dispose()
			{
			}//Discarded unreachable code: IL_0001

		}

		[Cpp2IlInjected.Token(Token = "0x40012F0")]
		public static bool isAgeGatePassed;

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		public static BaseUiRoot Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60008FB")]
			[Cpp2IlInjected.Address(RVA = "0x163D9D0", Offset = "0x163C3D0", VA = "0x18163D9D0")]
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60008FC")]
			[Cpp2IlInjected.Address(RVA = "0x163DCB0", Offset = "0x163C6B0", VA = "0x18163DCB0")]
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		public virtual Task LevelUpAnimationTask
		{
			[Cpp2IlInjected.Token(Token = "0x600090D")]
			[Cpp2IlInjected.Address(RVA = "0x163DA30", Offset = "0x163C430", VA = "0x18163DA30", Slot = "17")]
			get
			{
				int num = 0;
				return Task.CompletedTask;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		public virtual Task FriendshipAddedAnimationBlockerTask
		{
			[Cpp2IlInjected.Token(Token = "0x6000912")]
			[Cpp2IlInjected.Address(RVA = "0x163D980", Offset = "0x163C380", VA = "0x18163D980", Slot = "22")]
			get
			{
				int num = 0;
				return Task.CompletedTask;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		public virtual Task RewardAnimationBlockerTask
		{
			[Cpp2IlInjected.Token(Token = "0x6000915")]
			[Cpp2IlInjected.Address(RVA = "0x163DA80", Offset = "0x163C480", VA = "0x18163DA80", Slot = "25")]
			get
			{
				int num = 0;
				return Task.CompletedTask;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		public virtual bool AreShortcutsBlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600091A")]
			[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "30")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event MenuChanged OnMenuChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0x163D7A0", Offset = "0x163C1A0", VA = "0x18163D7A0")]
			[CompilerGenerated]
			add
			{
				MenuChanged onMenuChanged = this.OnMenuChanged;
				Delegate @delegate = Delegate.Combine(onMenuChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMenuChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0x163DAD0", Offset = "0x163C4D0", VA = "0x18163DAD0")]
			[CompilerGenerated]
			remove
			{
				MenuChanged onMenuChanged = this.OnMenuChanged;
				Delegate @delegate = Delegate.Remove(onMenuChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMenuChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event MenuChanged OnPopupChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000922")]
			[Cpp2IlInjected.Address(RVA = "0x163D8E0", Offset = "0x163C2E0", VA = "0x18163D8E0")]
			[CompilerGenerated]
			add
			{
				MenuChanged onPopupChanged = this.OnPopupChanged;
				Delegate @delegate = Delegate.Combine(onPopupChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPopupChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0x163DC10", Offset = "0x163C610", VA = "0x18163DC10")]
			[CompilerGenerated]
			remove
			{
				MenuChanged onPopupChanged = this.OnPopupChanged;
				Delegate @delegate = Delegate.Remove(onPopupChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onPopupChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event MenuSection OnMenuSectionChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0x163D840", Offset = "0x163C240", VA = "0x18163D840")]
			[CompilerGenerated]
			add
			{
				MenuSection onMenuSectionChange = this.OnMenuSectionChange;
				Delegate @delegate = Delegate.Combine(onMenuSectionChange, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMenuSectionChange)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0x163DB70", Offset = "0x163C570", VA = "0x18163DB70")]
			[CompilerGenerated]
			remove
			{
				MenuSection onMenuSectionChange = this.OnMenuSectionChange;
				Delegate @delegate = Delegate.Remove(onMenuSectionChange, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onMenuSectionChange)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x163C4D0", Offset = "0x163AED0", VA = "0x18163C4D0")]
		private void Awake()
		{
			UnityEngine.Object.DontDestroyOnLoad(this);
			Instance = this;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x163C940", Offset = "0x163B340", VA = "0x18163C940", Slot = "4")]
		public virtual Task Fade(float duration, Color startColor, Color endColor, EasingFunction easing, LoadingLogoAction action = LoadingLogoAction.None, bool preventSameColorTransition = true, bool isIconMiddle = false)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x163CFF0", Offset = "0x163B9F0", VA = "0x18163CFF0", Slot = "5")]
		public virtual Task PlayCharacterSummon(Mdl.Characters.Character character, GameObject summonEffect)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x163D040", Offset = "0x163BA40", VA = "0x18163D040", Slot = "6")]
		public virtual Task<int> PlayerTaskChoiceDialog(List<PlayerTaskDefinition> playerTasks, GameObject target, CancellationToken ct)
		{
			return (Task<int>)(object)Task.FromResult(-1);
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x163CD10", Offset = "0x163B710", VA = "0x18163CD10")]
		[AsyncStateMachine(typeof(_003COpenFtueMenu_003Ed__8))]
		public Task OpenFtueMenu(AssetReference menuAssetReference, bool isPopup, bool waitUntilExit)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x163CEB0", Offset = "0x163B8B0", VA = "0x18163CEB0", Slot = "7")]
		public virtual Task OpenMenu(AssetReference menuAssetReference, bool isPopup = false, bool waitUntilExit = true, params object[] parameters)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x163CFA0", Offset = "0x163B9A0", VA = "0x18163CFA0", Slot = "8")]
		public virtual Task OpenSystemMenu(AssetReference menuAssetReference, params object[] parameters)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x163CBC0", Offset = "0x163B5C0", VA = "0x18163CBC0")]
		[AsyncStateMachine(typeof(_003COpenFtueMenuWithAnswer_003Ed__11))]
		public Task<int> OpenFtueMenuWithAnswer(AssetReference menuAssetReference, bool isPopup)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<int>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x163CE50", Offset = "0x163B850", VA = "0x18163CE50", Slot = "9")]
		public virtual Task<int> OpenMenuWithAnswer(AssetReference menuAssetReference, bool isPopup = false, params object[] parameters)
		{
			return (Task<int>)(object)Task.FromResult(0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x163C830", Offset = "0x163B230", VA = "0x18163C830", Slot = "10")]
		public virtual Task DoPostCharacterUnlockFlow(Item characterItem, bool skipPhotoMode, CancellationToken ct, bool fastFade = false)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x163CF00", Offset = "0x163B900", VA = "0x18163CF00", Slot = "11")]
		public virtual Task OpenPhotoMenu(PhotoModeType photoMode, CancellationToken ct, [Optional] Transform freeCamStartTransform)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		public virtual void ShowCollectionReminder(CollectionSubMenu collectionSubMenu, string stringID)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "13")]
		public virtual IDisposable ShowThrobber(string key, bool showLogo = true, bool freezeRendering = false)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "14")]
		public virtual IDisposable HideThrobber(string key)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "15")]
		public virtual void StartLevelUpAnimationBlocker()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "16")]
		public virtual void StopLevelUpAnimationBlocker()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "18")]
		public virtual bool GameReset()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "19")]
		public virtual bool GameForceQuit()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "20")]
		public virtual void StartFriendshipAddedBlocker()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "21")]
		public virtual void StopFriendshipAddedBlocker()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "23")]
		public virtual void StartRewardAnimationBlocker()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "24")]
		public virtual void StopRewardAnimationBlocker()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "26")]
		public virtual void StartAddToBackpackAnimationBlocker()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "27")]
		public virtual void StopAddToBackpackAnimationBlocker()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "28")]
		public virtual void StartConsummableHighlight()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "29")]
		public virtual void StopConsummableHighlight()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "31")]
		public virtual void ForceAllowShortCuts()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "32")]
		public virtual void StopForceAllowShortcuts()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "33")]
		public virtual void StartBlockShortCuts()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "34")]
		public virtual void StopBlockShortcuts()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x163D0A0", Offset = "0x163BAA0", VA = "0x18163D0A0", Slot = "35")]
		public virtual void RaiseMenuChanged(string menuName)
		{
			this.OnMenuChanged?.Invoke(menuName);
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x163D0E0", Offset = "0x163BAE0", VA = "0x18163D0E0", Slot = "36")]
		public virtual void RaisePopupChanged(string popupName)
		{
			this.OnPopupChanged?.Invoke(popupName);
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x163D0C0", Offset = "0x163BAC0", VA = "0x18163D0C0", Slot = "37")]
		public virtual void RaiseMenuSectionChanged(string menuSectionName)
		{
			this.OnMenuSectionChange?.Invoke(menuSectionName);
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x163C790", Offset = "0x163B190", VA = "0x18163C790", Slot = "38")]
		public virtual Task DisplayInfoGizmo(GameObject target, GameObject infoGizmoPrefab, CancellationToken ct, params object[] parameters)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x163C7E0", Offset = "0x163B1E0", VA = "0x18163C7E0", Slot = "39")]
		public virtual Task DisplayInfoGizmo(GameObject target, AssetReferenceGameObject infoGizmoPrefab, CancellationToken ct, params object[] parameters)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "40")]
		public virtual void RefreshQuestMarkers()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "41")]
		public virtual void ShowQuestMarkers()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "42")]
		public virtual bool HideQuestMarkers()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "43")]
		public virtual void ShowLootOfflineMarkers()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "44")]
		public virtual void HideLootOfflineMarkers()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "45")]
		public virtual void ShowMailboxMarkers()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "46")]
		public virtual void HideMailboxMarkers()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "47")]
		public virtual void LoadMainMenu()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "48")]
		public virtual void LoadMainMenuSettings()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "49")]
		public virtual void LoadMainMenuRoadmap()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "50")]
		public virtual void LoadMainMenuLinkAccount()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "51")]
		public virtual void LoadMainMenuRegisterEmail()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "52")]
		public virtual void LoadMainMenuCredits()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "53")]
		public virtual void ShowHud()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "54")]
		public virtual void HideHud()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "55")]
		public virtual void ClearHud()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x163CB10", Offset = "0x163B510", VA = "0x18163CB10", Slot = "56")]
		public virtual Task LoadHud()
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x163D690", Offset = "0x163C090", VA = "0x18163D690", Slot = "57")]
		public virtual Task WaitForHUD(CancellationToken ct)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "58")]
		public virtual void SetHudCritterQueueNotif(bool enable)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "59")]
		public virtual void ShowQueuedCritterNotifs()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "60")]
		public virtual void PopAllFromPopupStack()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "61")]
		public virtual void PopMenuStack()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "62")]
		public virtual void GoBackToHudMenu()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x163D630", Offset = "0x163C030", VA = "0x18163D630", Slot = "63")]
		[Obsolete]
		public virtual Task<GenericAlertAction> UIAlert(string message, string title = "", string confirmLabel = "OK", string cancelLabel = "CANCEL", bool showCancelButton = false, bool showCloseButton = true, [Optional] string iconPath, bool showConfirmButton = true, bool dismissAfter = true, bool isHandoverCodePopup = false, bool showPurchaseButton = false, [Optional] IItemData costCurrency, int costAmount = 0, string purchaseLabel = "Shop.btn_free", [Optional] CancellationToken ct)
		{
			return (Task<GenericAlertAction>)(object)Task.FromResult(GenericAlertAction.Close);
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x163D590", Offset = "0x163BF90", VA = "0x18163D590", Slot = "64")]
		public virtual Task<AlertButton> UIAlert(IEnumerable<string> messages, IEnumerable<AlertButton> buttons, string title = "", bool showCloseButton = true, string popupSfx = "", [Optional] AK.Wwise.Event confirmSfx, [Optional] AK.Wwise.Event cancelSfx, [Optional] CancellationToken ct)
		{
			//IL_0009: Expected O, but got I4
			int isDefaultGamepadFocus = default(int);
			int num = default(int);
			int style = default(int);
			AlertButton result = new AlertButton((AlertButtonStyle)style, (string)num, (byte)isDefaultGamepadFocus != 0);
			isDefaultGamepadFocus = 0;
			num = 0;
			style = 0;
			return (Task<AlertButton>)(object)Task.FromResult(result);
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x163D4F0", Offset = "0x163BEF0", VA = "0x18163D4F0", Slot = "65")]
		public virtual Task<AlertButton> UIAlert(string message, IEnumerable<AlertButton> buttons, string title = "", bool showCloseButton = true, string popupSfx = "", [Optional] AK.Wwise.Event confirmSfx, [Optional] AK.Wwise.Event cancelSfx, [Optional] CancellationToken ct)
		{
			//IL_0009: Expected O, but got I4
			int isDefaultGamepadFocus = default(int);
			int num = default(int);
			int style = default(int);
			AlertButton result = new AlertButton((AlertButtonStyle)style, (string)num, (byte)isDefaultGamepadFocus != 0);
			isDefaultGamepadFocus = 0;
			num = 0;
			style = 0;
			return (Task<AlertButton>)(object)Task.FromResult(result);
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x163D450", Offset = "0x163BE50", VA = "0x18163D450", Slot = "66")]
		public virtual Task<AlertButton> SystemAlertAsync(string message, [Optional] IEnumerable<AlertButton> buttons, string title = "", string devNote = "", [Optional] Exception exception, bool allowClose = true, [Optional] CancellationToken ct)
		{
			//IL_0009: Expected O, but got I4
			int isDefaultGamepadFocus = default(int);
			int num = default(int);
			int style = default(int);
			AlertButton result = new AlertButton((AlertButtonStyle)style, (string)num, (byte)isDefaultGamepadFocus != 0);
			isDefaultGamepadFocus = 0;
			num = 0;
			style = 0;
			return (Task<AlertButton>)(object)Task.FromResult(result);
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "67")]
		public virtual IDisposable ShowGenericMessage(string message)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "68")]
		public virtual void ShowSharePrompt(PromptData data, int type)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "69")]
		public virtual void ShowDisconnectedControllerPrompt(PromptData promptData)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "70")]
		public virtual void UiErrorMessage(string msg, float duration = 2f)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "71")]
		public virtual void ShowNotEnoughCurrencyPopUp(IItemData itemData, int requiredAmount, [Optional] Item? productItem)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x163C730", Offset = "0x163B130", VA = "0x18163C730", Slot = "72")]
		public virtual Task<List<GiveItemsToCharacter.Types.ItemGiven>> DisplayGiveUI(CancellationToken ct, int maximumAmount = 1, [Optional] ItemFilterData itemFilter, bool missionGift = false, [Optional] Meta.Character character, [Optional] Mdl.Characters.Critters.Critter critter)
		{
			//IL_0006: Expected O, but got I4
			return (Task<List<GiveItemsToCharacter.Types.ItemGiven>>)(object)Task.FromResult((List<GiveItemsToCharacter.Types.ItemGiven>)0);
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "73")]
		public virtual void OpenCatalog(ItemFilterData itemFilterData)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "74")]
		public virtual void OpenWardrobe(ItemFilterData itemFilterData)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x163CB60", Offset = "0x163B560", VA = "0x18163CB60", Slot = "75")]
		public virtual Task<List<int>> OpenBackpackFullMenu(IEnumerable<ItemInstance> itemsToAdd, [Optional] IEnumerable<int> unavailablePositions)
		{
			//IL_0006: Expected O, but got I4
			return (Task<List<int>>)(object)Task.FromResult((List<int>)0);
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "76")]
		public virtual void OpenPhone(int tabIndex)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "77")]
		public virtual void OpenRoyalDuties()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x163D350", Offset = "0x163BD50", VA = "0x18163D350", Slot = "78")]
		public virtual Task<int> ShowLockedRegionPopup(int requiredLevel, int requiredCharacterUnlocked, CurrencyCost cost, Item unlockCharacter, string title = "", bool isRealm = false, int requiredMana = 0)
		{
			return (Task<int>)(object)Task.FromResult(0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x163D1C0", Offset = "0x163BBC0", VA = "0x18163D1C0", Slot = "79")]
		[AsyncStateMachine(typeof(_003CShowAgeGateDisclaimerPrompt_003Ed__98))]
		public virtual Task<bool> ShowAgeGateDisclaimerPrompt([Optional] Action onAcceptButton)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "80")]
		public virtual void ShowDisclaimerPrompt([Optional] Action onAcceptButton)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "81")]
		public virtual void ShowMailboxMenu()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x163D300", Offset = "0x163BD00", VA = "0x18163D300", Slot = "82")]
		public virtual Task ShowLevelUpMenu(object menuParams, CancellationToken ct)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x163D400", Offset = "0x163BE00", VA = "0x18163D400", Slot = "83")]
		public virtual Task ShowProfessionSelectionMenu(Item characterItem, CancellationToken ct)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x163D3B0", Offset = "0x163BDB0", VA = "0x18163D3B0", Slot = "84")]
		public virtual Task ShowProfessionChangedMenu(Item characterItem, CancellationToken ct)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x163D2B0", Offset = "0x163BCB0", VA = "0x18163D2B0", Slot = "85")]
		public virtual Task ShowCollection(Item unlockedItem)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "86")]
		public virtual void ShowNewItemPopup(Item item, int amount)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "87")]
		public virtual void CoinGainStore(Transform source, [Optional] RectTransform lastPos)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "88")]
		public virtual void CoinGainPickup([Optional] RectTransform lastPos, int amount = -1)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "89")]
		public virtual void GemGainStore(Transform source, [Optional] RectTransform lastPos)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "90")]
		public virtual void GemGainPickup([Optional] RectTransform lastPos, int amount = -1)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "91")]
		public virtual void InteractionPreview(GameObject gameObject, InteractPreviewData interactionMessage, params object[] args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "92")]
		public virtual void InteractionPreview(GameObject gameObject, InteractPreviewData[] interactionMessages, params object[] args)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "93")]
		public virtual void DestroyInteractionPreview()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "94")]
		public virtual void BackpackFull()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "95")]
		public virtual void ShowCutsceneSkipper(Action callback)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "96")]
		public virtual void HideCutsceneSkipper()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x163CF50", Offset = "0x163B950", VA = "0x18163CF50", Slot = "97")]
		public virtual Task OpenStallMenu(bool IsSell)
		{
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "98")]
		public virtual void ShowTutorialBlocker()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "99")]
		public virtual void HideTutorialBlocker()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "100")]
		public virtual void SetItemPreview(GameObject target)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "101")]
		public virtual T GetDebugProperty<T>(string propertyName)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "102")]
		public virtual void SetDebugProperty<T>(string propertyName, T newValue)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x163CA50", Offset = "0x163B450", VA = "0x18163CA50")]
		public Scope LevelUpAnimationBlocker()
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x163C990", Offset = "0x163B390", VA = "0x18163C990")]
		public Scope FriendshipAddedBlocker()
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x163D100", Offset = "0x163BB00", VA = "0x18163D100")]
		public Scope RewardAnimationBlocker()
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x163C410", Offset = "0x163AE10", VA = "0x18163C410")]
		public Scope AddToBackpackAnimationBlocker()
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x163C670", Offset = "0x163B070", VA = "0x18163C670")]
		public Scope ConsummableHighlight()
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x163C5B0", Offset = "0x163AFB0", VA = "0x18163C5B0")]
		public Scope BlockShortcuts()
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x163C880", Offset = "0x163B280", VA = "0x18163C880")]
		public Scope EnableBlockedShortcuts()
		{
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "103")]
		public virtual Scope BlockShortcutsAndIgnoreForceAllow()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x163D6E0", Offset = "0x163C0E0", VA = "0x18163D6E0", Slot = "104")]
		public virtual Task<IDisposable> WaitingExclusive()
		{
			//Discarded unreachable code: IL_000b
			return (Task<IDisposable>)(object)((TaskCompletionSource<>)(object)new TaskCompletionSource<TResult>()).m_task;
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public BaseUiRoot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		static BaseUiRoot()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}
}
