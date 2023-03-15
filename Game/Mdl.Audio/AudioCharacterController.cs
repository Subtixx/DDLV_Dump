using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Avatar;
using Mdl.Environments;
using Mdl.Grid;
using Mdl.Log;
using Mdl.Navigation;
using Mdl.Systems;
using Meta;
using Meta.Online;
using Serilog;
using UnityEngine;
using UnityEngine.AI;

namespace Mdl.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000AE5")]
	public class AudioCharacterController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000AE6")]
		public enum GrabEventReason
		{
			[Cpp2IlInjected.Token(Token = "0x4003C7B")]
			normal,
			[Cpp2IlInjected.Token(Token = "0x4003C7C")]
			minigame
		}

		[Cpp2IlInjected.Token(Token = "0x2000AE7")]
		public enum FishingEvents
		{
			[Cpp2IlInjected.Token(Token = "0x4003C7E")]
			cast,
			[Cpp2IlInjected.Token(Token = "0x4003C7F")]
			alert,
			[Cpp2IlInjected.Token(Token = "0x4003C80")]
			hooked,
			[Cpp2IlInjected.Token(Token = "0x4003C81")]
			success,
			[Cpp2IlInjected.Token(Token = "0x4003C82")]
			failed,
			[Cpp2IlInjected.Token(Token = "0x4003C83")]
			reel,
			[Cpp2IlInjected.Token(Token = "0x4003C84")]
			stopreel
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003C3B")]
		[Header("GENERAL")]
		public GameObject audioEmitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003C3C")]
		[Header("FOOTSTEPS SFX")]
		public AK.Wwise.Event FootStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003C3D")]
		public Switch ShoeDefaultSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003C3E")]
		public Switch ShoeLimboSwith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003C3F")]
		public Switch ShoeWetStepSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003C40")]
		public Switch ShoeDryStepSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003C41")]
		public List<FootStepStateEnumEntry> FootStepStateMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003C42")]
		public List<ShoeTypeSwitchEntry> ShoeTypeMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003C43")]
		public List<ClothingItemTypeBank> ShoeTypeBankMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003C44")]
		public List<ClothingItemTypeBank> AccBackTypeBankMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4003C45")]
		public List<ClothingItemTypeBank> AccHeadHatTypeBankMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4003C46")]
		public Transform leftFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003C47")]
		public Transform rightFoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4003C48")]
		public RTPC RTPCPlayerSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4003C49")]
		[Header("FOLEY SFX")]
		public AK.Wwise.Event sfxMcFoleyEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4003C4A")]
		private string clothStyleWwiseString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4003C4B")]
		public Switch AccBackDefaultSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4003C4C")]
		public Switch AccHeadHatDefaultSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4003C4D")]
		public Switch CloFullBodyDefaultSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4003C4E")]
		public List<AccBackTypeSwitchEntry> AccBackTypeList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4003C4F")]
		public List<AccHeadHatTypeSwitchEntry> AccHeadHatTypeList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4003C50")]
		public List<CloFullBodyTypeSwitchEntry> CloFullBodyTypeList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4003C51")]
		[Header("PICKUP SFX")]
		public AK.Wwise.Event PickupSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4003C52")]
		public Switch DefaultPickupSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4003C53")]
		public Switch isBurningStateSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4003C54")]
		public Switch notBurningStateSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4003C55")]
		public Switch FailPickupSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4003C56")]
		public List<ActionItemSwitchEntry> PickupSwitchItemMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4003C57")]
		public List<ActionItemTypeSwitchEntry> PickupSwitchItemTypeMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4003C58")]
		public List<ActionActivityItemTypeSwitchEntry> PickupSwitchActivityItemTypeMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4003C59")]
		public List<ActionCropTypeSwitchEntry> PickupSwitchCropTypeMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4003C5A")]
		public List<ActionToolTypeSwitchEntry> PickupSwitchToolTypeMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4003C5B")]
		public List<ActionCookingIngredientTypeEntry> PickupSwitchCookingIngredientList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4003C5C")]
		public AK.Wwise.Event miniEventCoinPickup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4003C5D")]
		[Header("FISHING")]
		public List<ActionEventEnumEntry> FishingEventsMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4003C5E")]
		public List<FishSuccessSwitchEntry> FishingSuccessMapList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4003C5F")]
		public AK.Wwise.Event stopReelingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4003C60")]
		public AK.Wwise.Event playLureImpactSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4003C61")]
		public Switch fishingImpactWaterSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4003C62")]
		public Switch fishingImpactGroundSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4003C63")]
		[Header("MISC")]
		public AK.Wwise.Event GiveItemSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4003C64")]
		public AK.Wwise.Event NPCGiveItemSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4003C65")]
		public AK.Wwise.Event NoEnergySFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4003C66")]
		[Space]
		private Dictionary<string, Switch> FootstepStateDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4003C67")]
		private Dictionary<int, Switch> ShoeTypeDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4003C68")]
		private Dictionary<int, Switch> AccBackTypeDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4003C69")]
		private Dictionary<int, Switch> AccHeadHatTypeDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4003C6A")]
		private Dictionary<int, Switch> CloFullBodyTypeDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4003C6B")]
		private Dictionary<string, AK.Wwise.Event> FishingEventsDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4003C6C")]
		private Dictionary<FishRarity, Switch> FishSuccessSwitchDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4003C6D")]
		private Dictionary<int, Switch> PickupItemSwitchDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4003C6E")]
		private Dictionary<ItemType, Switch> PickupItemTypeSwitchDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4003C6F")]
		private Dictionary<ActivityItemType, Switch> PickupActivityItemTypeSwitchDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4003C70")]
		private Dictionary<CropType, Switch> PickupCropTypeSwitchDict;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4003C71")]
		private Switch curShoeTypeSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4003C72")]
		private Bank curShoeBank;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4003C73")]
		private Switch curAccBackTypeSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4003C74")]
		private Switch curAccHeadHatTypeSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4003C75")]
		private Switch curCloFullBodyTypeSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4003C76")]
		private GridFloorType curFloorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4003C77")]
		private Bank curAccBackBank;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4003C78")]
		private Bank curAccHeadHatBank;

		[Cpp2IlInjected.Token(Token = "0x170006EE")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x208"), Cpp2IlInjected.Token(Token = "0x4003C79")]
		private Serilog.ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x6003209")]
			[Cpp2IlInjected.Address(RVA = "0xA4C8F0", Offset = "0xA4B2F0", VA = "0x180A4C8F0")]
			get;
		} = Serilogger.Create<AudioCharacterController>();


		[Cpp2IlInjected.Token(Token = "0x600320A")]
		[Cpp2IlInjected.Address(RVA = "0xA4B4B0", Offset = "0xA49EB0", VA = "0x180A4B4B0")]
		public void Start()
		{
			//Discarded unreachable code: IL_0120
			InitDictionaries();
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.AvatarCustomizationChanged value = OnAvatarCustomizationChanged;
			_003CDispatcher_003Ek__BackingField.OnAvatarCustomizationChanged -= value;
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField2 = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.AvatarCustomizationChanged value2 = OnAvatarCustomizationChanged;
			_003CDispatcher_003Ek__BackingField2.OnAvatarCustomizationChanged += value2;
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client.InitialLoginCompleted value3 = OnInitialLoginCompleted;
			metaClient.OnInitialLoginCompleted -= value3;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			Client.InitialLoginCompleted value4 = OnInitialLoginCompleted;
			metaClient2.OnInitialLoginCompleted += value4;
			PlayerAvatar avatar = SystemRoot.Instance._avatar;
			PlayerAvatar.AvatarTeleported value5 = OnAvatarTeleported;
			avatar.OnAvatarTeleported -= value5;
			PlayerAvatar avatar2 = SystemRoot.Instance._avatar;
			PlayerAvatar.AvatarTeleported value6 = OnAvatarTeleported;
			avatar2.OnAvatarTeleported += value6;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= AnyEnvironmentEnteredEvent;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += AnyEnvironmentEnteredEvent;
			bool flag = default(bool);
			if (flag)
			{
				EventHandler<bool> eventHandler = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(LimboStateChanged);
				EventHandler<bool> eventHandler2 = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(LimboStateChanged);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600320B")]
		[Cpp2IlInjected.Address(RVA = "0xA48170", Offset = "0xA46B70", VA = "0x180A48170")]
		private void InitDictionaries()
		{
			//Discarded unreachable code: IL_002e, IL_0033, IL_004e, IL_006e, IL_0073, IL_0086, IL_00a6, IL_00ab, IL_00be, IL_00de, IL_00e3, IL_00f6, IL_0116, IL_011b, IL_0132, IL_0152, IL_0157, IL_016a, IL_018a, IL_018f, IL_01a2, IL_01c2, IL_01c7, IL_01e0, IL_01e5, IL_01f8, IL_0218, IL_021d, IL_0230, IL_0250, IL_0255, IL_0268, IL_0288, IL_028d, IL_02a0, IL_02af, IL_02b5, IL_02bb, IL_02c1, IL_02c7, IL_02cd, IL_02d3, IL_02d9, IL_02e5, IL_02eb, IL_02f1, IL_02fd, IL_0303, IL_0309, IL_0315, IL_031b, IL_0321, IL_032d, IL_0333, IL_0339, IL_0345, IL_034b, IL_0351, IL_035d, IL_0363, IL_0369, IL_0375, IL_037b, IL_0381, IL_038d, IL_0393, IL_0399, IL_03a5, IL_03ab, IL_03b1, IL_03bd, IL_03c3, IL_03c9
			//IL_0049: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			//IL_0081: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			//IL_00f1: Expected O, but got I4
			//IL_0129: Expected O, but got I4
			//IL_0165: Expected O, but got I4
			//IL_019d: Expected O, but got I4
			//IL_01f3: Expected O, but got I4
			//IL_022b: Expected O, but got I4
			//IL_0263: Expected O, but got I4
			//IL_029b: Expected O, but got I4
			bool flag = default(bool);
			bool flag2 = default(bool);
			NullReferenceException ex = default(NullReferenceException);
			bool flag3 = default(bool);
			NullReferenceException ex2 = default(NullReferenceException);
			bool flag4 = default(bool);
			NullReferenceException ex3 = default(NullReferenceException);
			bool flag5 = default(bool);
			NullReferenceException ex4 = default(NullReferenceException);
			bool flag6 = default(bool);
			int num4 = default(int);
			bool flag7 = default(bool);
			NullReferenceException ex5 = default(NullReferenceException);
			bool flag8 = default(bool);
			NullReferenceException ex6 = default(NullReferenceException);
			bool flag9 = default(bool);
			NullReferenceException ex7 = default(NullReferenceException);
			bool flag10 = default(bool);
			NullReferenceException ex8 = default(NullReferenceException);
			bool flag11 = default(bool);
			NullReferenceException ex9 = default(NullReferenceException);
			bool flag12 = default(bool);
			int num5 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				Dictionary<string, Switch> dictionary = (FootstepStateDict = (Dictionary<string, Switch>)(object)new Dictionary<TKey, TValue>());
				List<FootStepStateEnumEntry> footStepStateMapList = FootStepStateMapList;
				if (flag)
				{
					Dictionary<string, Switch> footstepStateDict = FootstepStateDict;
					throw new NullReferenceException();
				}
				Dictionary<int, Switch> dictionary2 = (Dictionary<int, Switch>)(object)new Dictionary<TKey, TValue>();
				if (flag2)
				{
					throw new NullReferenceException();
				}
				if (ex == null)
				{
					Dictionary<int, Switch> dictionary3 = (Dictionary<int, Switch>)(object)new Dictionary<TKey, TValue>();
					if (flag3)
					{
						throw new NullReferenceException();
					}
					if (ex2 == null)
					{
						Dictionary<int, Switch> dictionary4 = (Dictionary<int, Switch>)(object)new Dictionary<TKey, TValue>();
						if (flag4)
						{
							throw new NullReferenceException();
						}
						if (ex3 == null)
						{
							Dictionary<int, Switch> dictionary5 = (Dictionary<int, Switch>)(object)new Dictionary<TKey, TValue>();
							if (flag5)
							{
								throw new NullReferenceException();
							}
							if (ex4 == null)
							{
								Dictionary<string, AK.Wwise.Event> dictionary6 = (Dictionary<string, AK.Wwise.Event>)(object)new Dictionary<TKey, TValue>();
								if (flag6)
								{
									throw new NullReferenceException();
								}
								if (num4 == 0)
								{
									Dictionary<FishRarity, Switch> dictionary7 = (Dictionary<FishRarity, Switch>)(object)new Dictionary<TKey, TValue>();
									if (flag7)
									{
										throw new NullReferenceException();
									}
									if (ex5 == null)
									{
										Dictionary<int, Switch> dictionary8 = (Dictionary<int, Switch>)(object)new Dictionary<TKey, TValue>();
										if (flag8)
										{
											throw new NullReferenceException();
										}
										if (ex6 == null)
										{
											if (flag9)
											{
												throw new NullReferenceException();
											}
											if (ex7 == null)
											{
												Dictionary<ItemType, Switch> dictionary9 = (Dictionary<ItemType, Switch>)(object)new Dictionary<TKey, TValue>();
												if (flag10)
												{
													throw new NullReferenceException();
												}
												if (ex8 == null)
												{
													Dictionary<ActivityItemType, Switch> dictionary10 = (Dictionary<ActivityItemType, Switch>)(object)new Dictionary<TKey, TValue>();
													if (flag11)
													{
														throw new NullReferenceException();
													}
													if (ex9 != null)
													{
														break;
													}
													Dictionary<CropType, Switch> dictionary11 = (Dictionary<CropType, Switch>)(object)new Dictionary<TKey, TValue>();
													if (flag12)
													{
														throw new NullReferenceException();
													}
													if (num5 == 0)
													{
														return;
													}
													continue;
												}
												throw new NullReferenceException();
											}
											throw new NullReferenceException();
										}
										throw new NullReferenceException();
									}
									throw new NullReferenceException();
								}
								throw new NullReferenceException();
							}
							throw new NullReferenceException();
						}
						throw new NullReferenceException();
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600320C")]
		[Cpp2IlInjected.Address(RVA = "0xA49E00", Offset = "0xA48800", VA = "0x180A49E00")]
		private void LimboStateChanged(object sender, bool e)
		{
			UpdateClotheItemType();
		}

		[Cpp2IlInjected.Token(Token = "0x600320D")]
		[Cpp2IlInjected.Address(RVA = "0xA4BF80", Offset = "0xA4A980", VA = "0x180A4BF80")]
		private unsafe void UpdateClotheItemType()
		{
			//Discarded unreachable code: IL_00d1
			//IL_005c: Expected O, but got I4
			//IL_006c: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00af: Expected O, but got I4
			//IL_00bf: Expected O, but got I4
			Client metaClient = SystemRoot.Instance.MetaClient;
			if (metaClient != null && (long)metaClient.profile != 0)
			{
				MapField<uint, int> clothes_ = SystemRoot.Instance.MetaClient.profile.player_.ActiveAvatar.clothes_;
				int num = 0;
				if ((SystemRoot.Instance.GetSystem<CurseSystem>().isLimboActive ? 1 : 0) != num || !((MapField<TKey, TValue>)(object)clothes_).TryGetValue((TKey)2, out *(TValue*)num) || ((Dictionary<TKey, TValue>)(object)ShoeTypeDict).TryGetValue((TKey)num, out *(TValue*)num))
				{
				}
				AkCallbackManager.BankCallback bankCallback = OnShoeSoundBankLoaded;
				if (!((MapField<TKey, TValue>)(object)clothes_).TryGetValue((TKey)8, out *(TValue*)num) || !((Dictionary<TKey, TValue>)(object)AccBackTypeDict).TryGetValue((TKey)num, out *(TValue*)num))
				{
				}
				AkCallbackManager.BankCallback bankCallback2 = OnAccBackSoundBankLoaded;
				if (!((MapField<TKey, TValue>)(object)clothes_).TryGetValue((TKey)4, out *(TValue*)num) || ((Dictionary<TKey, TValue>)(object)AccHeadHatTypeDict).TryGetValue((TKey)num, out *(TValue*)num))
				{
				}
				AkCallbackManager.BankCallback bankCallback3 = OnAccHeadHatSoundBankLoaded;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600320E")]
		[Cpp2IlInjected.Address(RVA = "0xA4A170", Offset = "0xA48B70", VA = "0x180A4A170")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_00ac
			//IL_000f: Expected O, but got I4
			//IL_006d: Expected O, but got I4
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			int num = 0;
			if (_003CInstance_003Ek__BackingField != (UnityEngine.Object)num)
			{
				if (SystemRoot.Instance.MetaClient != null)
				{
					Client client = default(Client);
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = client.Dispatcher;
					ProfileEventDispatcher.AvatarCustomizationChanged value = OnAvatarCustomizationChanged;
					_003CDispatcher_003Ek__BackingField.OnAvatarCustomizationChanged -= value;
					Client.InitialLoginCompleted value2 = OnInitialLoginCompleted;
					Client client2 = default(Client);
					client2.OnInitialLoginCompleted -= value2;
				}
				PlayerAvatar avatar = SystemRoot.Instance._avatar;
				int num2 = 0;
				if (avatar != (UnityEngine.Object)num2)
				{
					PlayerAvatar.AvatarTeleported value3 = OnAvatarTeleported;
					avatar.OnAvatarTeleported -= value3;
				}
			}
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= AnyEnvironmentEnteredEvent;
			bool flag = default(bool);
			if (flag)
			{
				EventHandler<bool> eventHandler = (EventHandler<bool>)(object)new EventHandler<TEventArgs>(LimboStateChanged);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600320F")]
		[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA467B0", VA = "0x180A47DB0")]
		private void AnyEnvironmentEnteredEvent(object sender, EventArgs e)
		{
			//Discarded unreachable code: IL_001a
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			GameObject rainFootStepState = audioEmitter;
			system.SetRainFootStepState(rainFootStepState);
		}

		[Cpp2IlInjected.Token(Token = "0x6003210")]
		[Cpp2IlInjected.Address(RVA = "0xA4B2D0", Offset = "0xA49CD0", VA = "0x180A4B2D0")]
		private void OnInitialLoginCompleted(Profile profile, CancellationToken ct)
		{
			//Discarded unreachable code: IL_002c
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client.InitialLoginCompleted value = OnInitialLoginCompleted;
			metaClient.OnInitialLoginCompleted -= value;
			UpdateClotheItemType();
			UpdateCloFullBody();
		}

		[Cpp2IlInjected.Token(Token = "0x6003211")]
		[Cpp2IlInjected.Address(RVA = "0xA49EA0", Offset = "0xA488A0", VA = "0x180A49EA0")]
		private void OnAvatarCustomizationChanged(bool success, List<ClothingInfo> newEquippedClothes, List<Item> newEquippedFeatures)
		{
			UpdateClotheItemType();
			UpdateCloFullBody();
		}

		[Cpp2IlInjected.Token(Token = "0x6003212")]
		[Cpp2IlInjected.Address(RVA = "0xA4C530", Offset = "0xA4AF30", VA = "0x180A4C530")]
		private void UpdateShoesHardness(MapField<uint, int> clothes)
		{
			//Discarded unreachable code: IL_0031
			bool flag = default(bool);
			if (!SystemRoot.Instance.GetSystem<CurseSystem>().isLimboActive && flag)
			{
				Dictionary<int, Switch> shoeTypeDict = ShoeTypeDict;
				bool flag2 = default(bool);
				if (!flag2)
				{
				}
			}
			AkCallbackManager.BankCallback bankCallback = OnShoeSoundBankLoaded;
		}

		[Cpp2IlInjected.Token(Token = "0x6003213")]
		[Cpp2IlInjected.Address(RVA = "0xA4B400", Offset = "0xA49E00", VA = "0x180A4B400")]
		private void OnShoeSoundBankLoaded(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie)
		{
			if (in_eLoadResult == AKRESULT.AK_Success)
			{
				Switch @switch = curShoeTypeSFX;
				if (@switch != null)
				{
					GameObject value = audioEmitter;
					@switch.SetValue(value);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003214")]
		[Cpp2IlInjected.Address(RVA = "0xA4BAC0", Offset = "0xA4A4C0", VA = "0x180A4BAC0")]
		private void UpdateAccBack(MapField<uint, int> clothes)
		{
			//Discarded unreachable code: IL_001f
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<int, Switch> accBackTypeDict = AccBackTypeDict;
				bool flag2 = default(bool);
				if (flag2)
				{
				}
			}
			AkCallbackManager.BankCallback bankCallback = OnAccBackSoundBankLoaded;
		}

		[Cpp2IlInjected.Token(Token = "0x6003215")]
		[Cpp2IlInjected.Address(RVA = "0xA4BC00", Offset = "0xA4A600", VA = "0x180A4BC00")]
		private void UpdateAccHeadHat(MapField<uint, int> clothes)
		{
			//Discarded unreachable code: IL_001f
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<int, Switch> accHeadHatTypeDict = AccHeadHatTypeDict;
				bool flag2 = default(bool);
				if (flag2)
				{
				}
			}
			AkCallbackManager.BankCallback bankCallback = OnAccHeadHatSoundBankLoaded;
		}

		[Cpp2IlInjected.Token(Token = "0x6003216")]
		[Cpp2IlInjected.Address(RVA = "0xA49E40", Offset = "0xA48840", VA = "0x180A49E40")]
		private void OnAccBackSoundBankLoaded(uint in_bankID, IntPtr in_InMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie)
		{
			if (in_eLoadResult == AKRESULT.AK_Success)
			{
				Switch @switch = curAccBackTypeSFX;
				if (@switch != null)
				{
					GameObject value = audioEmitter;
					@switch.SetValue(value);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003217")]
		[Cpp2IlInjected.Address(RVA = "0xA49E70", Offset = "0xA48870", VA = "0x180A49E70")]
		private void OnAccHeadHatSoundBankLoaded(uint in_bankID, IntPtr in_InMemoryBankPTR, AKRESULT in_eLoadResult, object in_Cookie)
		{
			if (in_eLoadResult == AKRESULT.AK_Success)
			{
				Switch @switch = curAccHeadHatTypeSFX;
				if (@switch != null)
				{
					GameObject value = audioEmitter;
					@switch.SetValue(value);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003218")]
		[Cpp2IlInjected.Address(RVA = "0xA47E90", Offset = "0xA46890", VA = "0x180A47E90")]
		private void ClotheItemLoadBankSetSwitch(ref Switch curSwitch, Switch newSwitch, List<ClothingItemTypeBank> bankList, ref Bank curBank, AkCallbackManager.BankCallback callback)
		{
			//IL_0023: Expected O, but got I4
			int num = 0;
			if (newSwitch != null)
			{
				string text = newSwitch.Name;
			}
			if (false)
			{
				return;
			}
			int num2 = 0;
			string curSwitchName = (string)num2;
			Func<ClothingItemTypeBank, bool> func = (Func<ClothingItemTypeBank, bool>)(object)(Func<T, TResult>)delegate(ClothingItemTypeBank x)
			{
				//Discarded unreachable code: IL_001b
				string a = x.switch_obj.Name;
				string b = curSwitchName;
				return string.Equals(a, b);
			};
			ClothingItemTypeBank clothingItemTypeBank = Enumerable.FirstOrDefault<ClothingItemTypeBank>((IEnumerable<>)bankList, (Func<, >)(object)func);
			Bank bank_obj;
			if (clothingItemTypeBank != null)
			{
				bank_obj = clothingItemTypeBank.bank_obj;
				if (bank_obj != null && bank_obj.IsValid())
				{
					Bank bank = curAccBackBank;
					string text2 = default(string);
					if (bank != null)
					{
						text2 = bank.Name;
						string text3 = bank_obj.Name;
						if (!(text2 != text3))
						{
							goto IL_008e;
						}
					}
					if (text2 == null)
					{
					}
					goto IL_008e;
				}
			}
			int num3 = 0;
			goto IL_00c2;
			IL_008e:
			Bank bank2 = curAccHeadHatBank;
			string text4 = default(string);
			if (bank2 != null)
			{
				text4 = bank2.Name;
				string text5 = bank_obj.Name;
				if (!(text4 != text5))
				{
					goto IL_00c2;
				}
			}
			if (text4 == null)
			{
			}
			return;
			IL_00c2:
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003219")]
		[Cpp2IlInjected.Address(RVA = "0xA4BD40", Offset = "0xA4A740", VA = "0x180A4BD40")]
		private unsafe void UpdateCloFullBody()
		{
			//Discarded unreachable code: IL_0080
			//IL_0043: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			int num = 0;
			Client metaClient = SystemRoot.Instance.MetaClient;
			if (metaClient != null && (long)metaClient.profile != 0)
			{
				Switch cloFullBodyDefaultSwitch = default(Switch);
				if (!((MapField<TKey, TValue>)(object)SystemRoot.Instance.MetaClient.profile.player_.ActiveAvatar.clothes_).TryGetValue((TKey)9, out *(TValue*)num) || !((Dictionary<TKey, TValue>)(object)CloFullBodyTypeDict).TryGetValue((TKey)num, out *(TValue*)num))
				{
					cloFullBodyDefaultSwitch = CloFullBodyDefaultSwitch;
				}
				curCloFullBodyTypeSFX = cloFullBodyDefaultSwitch;
				Switch @switch = curCloFullBodyTypeSFX;
				if (@switch != null)
				{
					GameObject value = audioEmitter;
					@switch.SetValue(value);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600321A")]
		[Cpp2IlInjected.Address(RVA = "0xA49E10", Offset = "0xA48810", VA = "0x180A49E10")]
		public void NoEnergy()
		{
			//Discarded unreachable code: IL_0017
			AK.Wwise.Event noEnergySFX = NoEnergySFX;
			GameObject gameObject = audioEmitter;
			uint num = noEnergySFX.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600321B")]
		[Cpp2IlInjected.Address(RVA = "0xA4C7B0", Offset = "0xA4B1B0", VA = "0x180A4C7B0")]
		public void callMcFoleyEvent(AnimationEvent animationEvent)
		{
			//Discarded unreachable code: IL_0070
			string stringParameter = animationEvent.stringParameter;
			int intParameter = animationEvent.intParameter;
			if (intParameter == 0)
			{
			}
			if (intParameter == 1)
			{
				clothStyleWwiseString = "gown";
			}
			string in_pszSwitchState = clothStyleWwiseString;
			GameObject in_gameObjectID = audioEmitter;
			AKRESULT aKRESULT = AkSoundEngine.SetSwitch("Cloth_Type", in_pszSwitchState, in_gameObjectID);
			GameObject in_gameObjectID2 = audioEmitter;
			AKRESULT aKRESULT2 = AkSoundEngine.SetSwitch("Mc_Movement_Type", stringParameter, in_gameObjectID2);
			AK.Wwise.Event @event = sfxMcFoleyEvent;
			GameObject gameObject = audioEmitter;
			uint num = @event.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x600321C")]
		[Cpp2IlInjected.Address(RVA = "0xA4A850", Offset = "0xA49250", VA = "0x180A4A850")]
		public void OnFootStep(string stateIn)
		{
			//Discarded unreachable code: IL_0130
			//IL_0028: Expected F4, but got I4
			NavMeshAgent _003CAgent_003Ek__BackingField = SystemRoot.Instance._avatar.Agent;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			int num = 0;
			float value = default(float);
			float num2 = Mathf.Clamp(value, num, 5f);
			RTPC rTPCPlayerSpeed = RTPCPlayerSpeed;
			if (rTPCPlayerSpeed != null)
			{
				float value2 = num2 * 20f;
				GameObject gameObject = audioEmitter;
				rTPCPlayerSpeed.SetValue(gameObject, value2);
			}
			if (!stateIn.Contains("_"))
			{
				return;
			}
			int startIndex = 0;
			int length = default(int);
			string text = stateIn.Substring(startIndex, length);
			Dictionary<string, Switch> footstepStateDict = FootstepStateDict;
			bool flag = default(bool);
			if (flag)
			{
				if (stateIn.Contains("_r"))
				{
				}
				Transform transform = leftFoot;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				GameObject gameObject2 = audioEmitter;
				SceneData sceneData = default(SceneData);
				AsyncOperation operation = sceneData.sceneInstance.m_Operation;
				CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
				SceneItemData sceneItemData = sceneData.sceneItemData;
				GameObject gameObject3 = default(GameObject);
				Mdl.Environments.Environment component = gameObject3.GetComponent<Mdl.Environments.Environment>();
				int force = 0;
				AudioManager audioManager = default(AudioManager);
				GridScript grid = default(GridScript);
				bool flag2 = audioManager.TryLocationAreaOverride(grid, (byte)force != 0);
				Transform transform2 = base.transform;
				Vector3 vector3 = default(Vector3);
				float z3 = vector3.z;
				bool flag3 = default(bool);
				if (!flag3)
				{
					AudioManager audioManager2 = default(AudioManager);
					Switch defaultFootStepGroundType = audioManager2.DefaultFootStepGroundType;
					GameObject value3 = audioEmitter;
					defaultFootStepGroundType.SetValue(value3);
				}
				AK.Wwise.Event footStep = FootStep;
				GameObject gameObject4 = audioEmitter;
				uint num3 = footStep.Post(gameObject4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600321D")]
		[Cpp2IlInjected.Address(RVA = "0xA49EC0", Offset = "0xA488C0", VA = "0x180A49EC0")]
		private void OnAvatarTeleported(Vector3 position, PlayerAvatar.AvatarTeleportedReason reason)
		{
			//Discarded unreachable code: IL_0070
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			GameObject rainFootStepState = audioEmitter;
			system.SetRainFootStepState(rainFootStepState);
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			SceneItemData sceneItemData = sceneData.sceneItemData;
			GameObject gameObject = default(GameObject);
			Mdl.Environments.Environment component = gameObject.GetComponent<Mdl.Environments.Environment>();
			Transform transform = base.transform;
			Vector3 vector = default(Vector3);
			float z = vector.z;
			GridScript grid = default(GridScript);
			bool flag = SystemRoot.Instance.GetSystem<AudioManager>().TryLocationAreaOverride(grid, force: true);
		}

		[Cpp2IlInjected.Token(Token = "0x600321E")]
		[Cpp2IlInjected.Address(RVA = "0xA4A630", Offset = "0xA49030", VA = "0x180A4A630")]
		public void OnFishingEventAudio(FishingEvents event_name, FishRarity rarity = FishRarity.Common)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_0028, IL_0036, IL_003b, IL_0056, IL_0057
			Dictionary<FishRarity, Switch> fishSuccessSwitchDict = FishSuccessSwitchDict;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600321F")]
		[Cpp2IlInjected.Address(RVA = "0xA4A7B0", Offset = "0xA491B0", VA = "0x180A4A7B0")]
		public void OnFishingEvent(string event_name)
		{
			//Discarded unreachable code: IL_000d, IL_0011, IL_002e, IL_002f
			Dictionary<string, AK.Wwise.Event> fishingEventsDict = FishingEventsDict;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003220")]
		[Cpp2IlInjected.Address(RVA = "0xA4B450", Offset = "0xA49E50", VA = "0x180A4B450")]
		public void SetLureImpactWater(bool canStartFishing)
		{
			//Discarded unreachable code: IL_0031
			if (!canStartFishing)
			{
			}
			Switch @switch = fishingImpactWaterSwitch;
			GameObject value = audioEmitter;
			@switch.SetValue(value);
			AK.Wwise.Event @event = playLureImpactSfx;
			GameObject gameObject = audioEmitter;
			uint num = @event.Post(gameObject);
		}

		[Cpp2IlInjected.Token(Token = "0x6003221")]
		[Cpp2IlInjected.Address(RVA = "0xA4B430", Offset = "0xA49E30", VA = "0x180A4B430")]
		public void PostSuccessFishingSFX()
		{
			AK.Wwise.Event @event = stopReelingSfx;
			if (@event != null)
			{
				GameObject gameObject = audioEmitter;
				uint num = @event.Post(gameObject);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003222")]
		[Cpp2IlInjected.Address(RVA = "0xA4ACD0", Offset = "0xA496D0", VA = "0x180A4ACD0")]
		public void OnGrabEvent(Item item, bool failed = false, bool burningState = false, GrabEventReason reason = GrabEventReason.normal, [Optional] GameObject pickUpGO)
		{
			//Discarded unreachable code: IL_00d7, IL_00dd, IL_00e3, IL_00e9
			//IL_005e: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (!burningState)
			{
			}
			Switch @switch = isBurningStateSwitch;
			GameObject value = audioEmitter;
			@switch.SetValue(value);
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Currency)
			{
				AK.Wwise.Event @event = miniEventCoinPickup;
				if (@event != null)
				{
					GameObject gameObject = audioEmitter;
					uint num4 = @event.Post(gameObject);
				}
			}
			if (!failed)
			{
				bool flag = default(bool);
				if (flag)
				{
					int num5 = 0;
					AudioPickUpData audioPickUpData = default(AudioPickUpData);
					if (audioPickUpData != (UnityEngine.Object)num5)
					{
						GameObject gameObject2 = audioEmitter;
						audioPickUpData.PlayPickupAudio(gameObject2);
						return;
					}
				}
				bool flag2 = default(bool);
				ActivityItemType activityItemType = default(ActivityItemType);
				if (!flag2)
				{
					ItemType itemType2 = default(ItemType);
					if (itemType2 != ItemType.ActivityItem)
					{
						goto IL_00c8;
					}
					if (activityItemType == ActivityItemType.Crop)
					{
						bool flag3 = default(bool);
						if (flag3)
						{
							bool flag4 = default(bool);
							while (!flag4)
							{
							}
							num++;
						}
						if (num + 1 != 0)
						{
						}
						CropItemData cropItemData = default(CropItemData);
						CropType cropType_ = cropItemData.cropType_;
						bool flag5 = default(bool);
						if (!flag5)
						{
						}
					}
				}
				ConsummableItemData consummableItemData = default(ConsummableItemData);
				if (activityItemType == ActivityItemType.Consummable && consummableItemData != null)
				{
					int contentItemType = (int)consummableItemData.ContentItemType;
					bool flag6 = default(bool);
					if (!flag6)
					{
					}
				}
				int num6 = (int)activityItemType;
				bool flag7 = default(bool);
				if (!flag7)
				{
				}
				goto IL_00c8;
			}
			goto IL_00d1;
			IL_00d1:
			throw new NullReferenceException();
			IL_00c8:
			ItemType itemType3 = default(ItemType);
			int num7 = (int)itemType3;
			bool flag8 = default(bool);
			while (flag8)
			{
			}
			goto IL_00d1;
		}

		[Cpp2IlInjected.Token(Token = "0x6003223")]
		[Cpp2IlInjected.Address(RVA = "0xA4C730", Offset = "0xA4B130", VA = "0x180A4C730")]
		public AudioCharacterController()
		{
		}
	}
}
