using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ABD")]
	public sealed class ProfileUpdater
	{
		[Cpp2IlInjected.Token(Token = "0x2000ABE")]
		public enum UpdateStatus
		{
			[Cpp2IlInjected.Token(Token = "0x4002AE4")]
			NotChecked,
			[Cpp2IlInjected.Token(Token = "0x4002AE5")]
			InvalidVersion,
			[Cpp2IlInjected.Token(Token = "0x4002AE6")]
			NoUpdateListEmpty,
			[Cpp2IlInjected.Token(Token = "0x4002AE7")]
			NoUpdateInitialVersionUpToDate,
			[Cpp2IlInjected.Token(Token = "0x4002AE8")]
			NoUpdateProfileVersionUpToDate,
			[Cpp2IlInjected.Token(Token = "0x4002AE9")]
			NoUpdateAvailable,
			[Cpp2IlInjected.Token(Token = "0x4002AEA")]
			Updated
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002ADE")]
		private readonly JObject profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002ADF")]
		private List<ProfileUpdate> profileUpdatesSorted = (List<ProfileUpdate>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002AE1")]
		public List<ProfileUpdate> ProfileUpdatedApplied = (List<ProfileUpdate>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x1700103F")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x4002AE0")]
		public UpdateStatus CurrentStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6005D26")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6005D27")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x17001040")]
		public bool HasAnyUpdateApplied
		{
			[Cpp2IlInjected.Token(Token = "0x6005D29")]
			[Cpp2IlInjected.Address(RVA = "0x1476D90", Offset = "0x1475790", VA = "0x181476D90")]
			get
			{
				//Discarded unreachable code: IL_0009
				List<ProfileUpdate> profileUpdatedApplied = ProfileUpdatedApplied;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001041")]
		public Profile UpdatedProfile
		{
			[Cpp2IlInjected.Token(Token = "0x6005D2A")]
			[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
			[CompilerGenerated]
			get
			{
				return _003CUpdatedProfile_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6005D2B")]
			[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
			[CompilerGenerated]
			private set
			{
				_003CUpdatedProfile_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001042")]
		public int InitialVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6005D2C")]
			[Cpp2IlInjected.Address(RVA = "0x1476DE0", Offset = "0x14757E0", VA = "0x181476DE0")]
			get
			{
				JObject jObject = profile;
				uint num = num + 20;
				num += num;
				string text = default(string);
				if (text == null)
				{
					JObject jObject2 = profile;
					uint num2 = num2 + 20;
					num2 += num2;
					uint num3 = num3 + 20;
					num3 += num3;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001043")]
		public int ProfileVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6005D2D")]
			[Cpp2IlInjected.Address(RVA = "0x1476F50", Offset = "0x1475950", VA = "0x181476F50")]
			get
			{
				JObject jObject = profile;
				uint num = num + 20;
				num += num;
				string text = default(string);
				if (text == null)
				{
					JObject jObject2 = profile;
					uint num2 = num2 + 20;
					num2 += num2;
					uint num3 = num3 + 20;
					num3 += num3;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D28")]
		[Cpp2IlInjected.Address(RVA = "0x1475D90", Offset = "0x1474790", VA = "0x181475D90")]
		public bool HasAnyUpdate(int version)
		{
			//Discarded unreachable code: IL_001d
			List<ProfileUpdate> cpp2il__autoParamName__idx_ = profileUpdatesSorted;
			int num = 0;
			ProfileUpdate profileUpdate = ((IEnumerable<>)cpp2il__autoParamName__idx_).Last<ProfileUpdate>();
			return version <= profileUpdate.Version;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D2E")]
		[Cpp2IlInjected.Address(RVA = "0x1475E10", Offset = "0x1474810", VA = "0x181475E10")]
		private bool TrySetCurrentVersionToProfile()
		{
			//Discarded unreachable code: IL_0058
			if (CurrentStatus == UpdateStatus.InvalidVersion)
			{
				int num = 0;
			}
			JToken jToken = this.profile["GameInfo"];
			JToken jToken3 = (jToken["Version"] = Profile.CurrentVersion);
			Profile profile = UpdatedProfile;
			if (profile != null)
			{
				ProfileGameInfo gameInfo_ = profile.gameInfo_;
				int num2 = (gameInfo_.version_ = Profile.CurrentVersion);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D2F")]
		[Cpp2IlInjected.Address(RVA = "0x1B12DA0", Offset = "0x1B117A0", VA = "0x181B12DA0")]
		private void AddUpdate<T>(int P_0) where T : ProfileUpdate, new()
		{
			//Discarded unreachable code: IL_0029
			if (!Enumerable.Any<ProfileUpdate>((IEnumerable<>)profileUpdatesSorted) || ((IEnumerable<>)profileUpdatesSorted).Last<ProfileUpdate>().Version < P_0)
			{
				List<ProfileUpdate> list = profileUpdatesSorted;
				return;
			}
			string message = default(string);
			Exception ex = new Exception(message);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D30")]
		[Cpp2IlInjected.Address(RVA = "0x1476490", Offset = "0x1474E90", VA = "0x181476490")]
		internal ProfileUpdater(JObject profile)
		{
			//IL_0030: Expected I4, but got I8
			this.profile = profile;
			CurrentStatus = UpdateStatus.NotChecked;
			uint num = default(uint);
			AddUpdate<ArielVillageRequestProfileUpdate>((int)num);
			uint num2 = default(uint);
			AddUpdate<April12ClothingRemovalUpdate>((int)num2);
			uint num3 = default(uint);
			AddUpdate<EricVillageRequestsUpdate>((int)num3);
			uint num4 = default(uint);
			AddUpdate<UrsulaHouseInteriorUpdate>((int)num4);
			uint num5 = default(uint);
			AddUpdate<PostEarlyAccessRemovalProfileUpdate>((int)num5);
			uint num6 = default(uint);
			AddUpdate<May10DisneyFeedbackRemovalProfileUpdate>((int)num6);
			uint num7 = default(uint);
			AddUpdate<VillageObjectLimitRefactoringProfileUpdate>((int)num7);
			uint num8 = default(uint);
			AddUpdate<May31ClothingRemovalUpdate>((int)num8);
			uint num9 = default(uint);
			AddUpdate<ReducePendingFishNumberProfileUpdate>((int)num9);
			uint num10 = default(uint);
			AddUpdate<FrozenRealmProfileUpdate>((int)num10);
			uint num11 = default(uint);
			AddUpdate<MultipleGridsInRealmProfileUpdate>((int)num11);
			uint num12 = default(uint);
			AddUpdate<DecalInventoryProfileUpdate>((int)num12);
			uint num13 = default(uint);
			AddUpdate<MoanaRealmGridFailProfileUpdate>((int)num13);
			uint num14 = default(uint);
			AddUpdate<RemoveEricBlockerProfileUpdate>((int)num14);
			uint num15 = default(uint);
			AddUpdate<AvatarTransferGhostClothesProfileUpdate>((int)num15);
			uint num16 = default(uint);
			AddUpdate<SavannahUpdateProfileUpdate>((int)num16);
			uint num17 = default(uint);
			AddUpdate<ScarHouseProfileUpdate>((int)num17);
			uint num18 = default(uint);
			AddUpdate<WallDecalsProfileUpdate>((int)num18);
			uint num19 = default(uint);
			AddUpdate<September21ItemRemovalProfileUpdate>((int)num19);
			uint num20 = default(uint);
			AddUpdate<ProfileConditionalUpdate1>((int)num20);
			uint num21 = default(uint);
			AddUpdate<PossessBeforeCraftCookProfileUpdate>((int)num21);
			uint num22 = default(uint);
			AddUpdate<ElsaNewVisitAreaStepProfileUpdate>((int)num22);
			uint num23 = default(uint);
			AddUpdate<AddHalloweenMakeupsProfileUpdate>((int)num23);
			uint num24 = default(uint);
			AddUpdate<MerlinMushroomProfileUpdate>((int)num24);
			uint num25 = default(uint);
			AddUpdate<UpdateInboxMsgExpiration>((int)num25);
			uint num26 = default(uint);
			AddUpdate<OldPickledHerringProfileUpdate>((int)num26);
			uint num27 = default(uint);
			AddUpdate<OldPickledHerring2ProfileUpdate>((int)num27);
			uint num28 = default(uint);
			AddUpdate<RedoMotherGothelFixProfileUpdate>((int)num28);
			uint num29 = default(uint);
			AddUpdate<FixCompletedCollectionsWithNewItemsProfileUpdate>((int)num29);
			uint num30 = default(uint);
			AddUpdate<ToyStoryRealmProfileUpdate>((int)num30);
			uint num31 = default(uint);
			AddUpdate<ProfileConditionalUpdate2NewContent>((int)num31);
			uint num32 = default(uint);
			AddUpdate<SkinInventoryProfileUpdate>((int)num32);
			uint num33 = default(uint);
			AddUpdate<PictureFrameProfileUpdate>((int)num33);
			uint num34 = default(uint);
			AddUpdate<AddToggleStatesOnGridObjectsProfileUpdate>((int)num34);
			uint num35 = default(uint);
			AddUpdate<ProfileConditionalUpdate2>((int)num35);
			uint num36 = default(uint);
			AddUpdate<UrsulaPaperProfileUpdate>((int)num36);
			uint num37 = default(uint);
			AddUpdate<FixDaylightSavingProfileUpdate>((int)num37);
			uint num38 = default(uint);
			AddUpdate<MotherGothel040NewMakeGardenStepProfileUpdate>((int)num38);
			uint num39 = default(uint);
			AddUpdate<HolidayEventProfileUpdate>((int)num39);
			uint num40 = default(uint);
			AddUpdate<Ariel020MemoryShardProfileUpdate>((int)num40);
			uint num41 = default(uint);
			AddUpdate<FixDecorateProgressionProfileUpdate>((int)num41);
			uint num42 = default(uint);
			AddUpdate<DonaldSecretMissionsProfileUpdate>((int)num42);
			uint num43 = default(uint);
			AddUpdate<VillageGridDataChangesProfileUpdate>((int)num43);
			uint num44 = default(uint);
			AddUpdate<DeliverySystemRefactoringProfileUpdate>((int)num44);
			uint num45 = default(uint);
			AddUpdate<HouseSkinsProfileUpdate>((int)num45);
			uint num46 = default(uint);
			AddUpdate<DoorConversionProfileUpdate>((int)num46);
			uint num47 = default(uint);
			AddUpdate<StorageManagementProfileUpdate>((int)num47);
			uint num48 = default(uint);
			AddUpdate<MoveSavannahMenhirProfileUpdate>((int)num48);
			uint num49 = default(uint);
			AddUpdate<ProfileConditionalUpdate3>((int)num49);
			uint num50 = default(uint);
			AddUpdate<AddMissingAtlanteanCrystalProfileUpdate>((int)num50);
			uint num51 = default(uint);
			AddUpdate<RemoveIceBlockersProfileUpdate>((int)num51);
			uint num52 = default(uint);
			AddUpdate<StorageBlockMoveToProfileUpdate>((int)num52);
			uint num53 = default(uint);
			AddUpdate<StitchRepairedTVProfileUpdate>((int)num53);
			uint num54 = default(uint);
			AddUpdate<DonaldSecretMissionsProfileUpdate>((int)num54);
			uint num55 = default(uint);
			AddUpdate<UrsulaKeyholePossessProfileUpdate>((int)num55);
			uint num56 = default(uint);
			AddUpdate<UrsulaPaperProfileUpdate>((int)num56);
			uint num57 = default(uint);
			AddUpdate<ProfileConditionalUpdate3_Hotfix>((int)num57);
			Func<ProfileUpdate, int> _003C_003E9__21_ = _003C_003Ec._003C_003E9__21_0;
			if (_003C_003E9__21_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ProfileUpdate x) => x.Version);
			}
			List<ProfileUpdate> list = (profileUpdatesSorted = (List<ProfileUpdate>)(object)Enumerable.ToList<ProfileUpdate>((IEnumerable<>)Enumerable.OrderBy<ProfileUpdate, int>((IEnumerable<>)profile, (Func<, >)(object)_003C_003E9__21_)));
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005D31")]
		[Cpp2IlInjected.Address(RVA = "0x1475670", Offset = "0x1474070", VA = "0x181475670")]
		internal void CheckAndUpdateProfile()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6005D32")]
		[Cpp2IlInjected.Address(RVA = "0x1475F70", Offset = "0x1474970", VA = "0x181475F70")]
		internal static bool TryToApplyProfileUpdate(ref string jsonText, out Profile profile)
		{
			//Discarded unreachable code: IL_00ab, IL_00b1, IL_00b7, IL_00bd
			//IL_0033: Expected O, but got I4
			//IL_0033: Expected O, but got I4
			//IL_0049: Expected O, but got I4
			//IL_007d: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			JObject jObject = default(JObject);
			ProfileUpdater profileUpdater = new ProfileUpdater(jObject);
			profileUpdater.CheckAndUpdateProfile();
			UpdateStatus updateStatus = profileUpdater.CurrentStatus;
			int currentVersion = Profile.CurrentVersion;
			string text = $"[LoadProfile] Profile updates checked => Result={updateStatus}, CurrentVersion={currentVersion}";
			List<ProfileUpdate> profileUpdatedApplied = profileUpdater.ProfileUpdatedApplied;
			bool flag = default(bool);
			if (flag)
			{
				string name = num2.GetType().Name;
				string text2 = $"[LoadProfile] Profile update successfully applied: Name={name}, Version={name}";
			}
			if (profileUpdater.CurrentStatus == UpdateStatus.InvalidVersion)
			{
				int currentVersion2 = Profile.CurrentVersion;
				string text3 = $"[LoadProfile] Current version of the game {currentVersion2} must be higher than the most recent profile update version. Did you forget to increment it in 'Profile.cs' ?";
			}
			List<ProfileUpdate> profileUpdatedApplied2 = profileUpdater.ProfileUpdatedApplied;
			string text4 = profileUpdater.UpdatedProfile.ToString();
			Profile profile2 = profileUpdater.UpdatedProfile;
			List<ProfileUpdate> profileUpdatedApplied3 = profileUpdater.ProfileUpdatedApplied;
			bool result = default(bool);
			return result;
		}
	}
}
