using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Scene;
using glPlayFab.Disney;
using Google.Protobuf.Collections;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AF7")]
	internal class ToyStoryRealmProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DC5")]
		[Cpp2IlInjected.Address(RVA = "0x78A620", Offset = "0x789020", VA = "0x18078A620", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_00ab
			//IL_0016: Expected O, but got I4
			//IL_002f: Expected I4, but got I8
			//IL_003c: Expected I4, but got I8
			//IL_00aa: Expected O, but got I4
			uint num = default(uint);
			RepeatedField<BodyOfWater> bodiesOfWater_ = ((Village.Types.VillageArea)((MapField<TKey, TValue>)(object)profile.world_.village_.areas_)[(TKey)num]).bodiesOfWater_;
			BodyOfWater bodyOfWater = new BodyOfWater();
			bodyOfWater.requestedFishConditionID_ = 2130000290;
			bodyOfWater.requestedFishItemID_ = 31500098;
			ActivityDataLocationFilter activityDataLocationFilter = new ActivityDataLocationFilter();
			activityDataLocationFilter.VillageArea = VillageAreaType.Savannah;
			bodyOfWater.location_ = activityDataLocationFilter;
			((RepeatedField<T>)(object)bodiesOfWater_).Add((T)bodyOfWater);
			RepeatedField<Character> characters_ = profile.world_.characters_;
			Func<Character, bool> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			if (_003C_003E9__0_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Character x) => x.base_.id_ == 10000032);
			}
			Character character = Enumerable.FirstOrDefault<Character>((IEnumerable<>)(object)characters_, (Func<, >)(object)_003C_003E9__0_);
			if (character != null)
			{
				character.secretCharacterData_ = (SecretCharacterRecurringConditionData)(character.status_ = Character.Types.CharacterStatus.InRealm);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DC6")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public ToyStoryRealmProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
