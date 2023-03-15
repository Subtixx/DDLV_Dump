using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Grids;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AFB")]
	internal class PictureFrameProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DCE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4530", Offset = "0x7B2F30", VA = "0x1807B4530", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_009d
			//IL_0094: Expected O, but got I4
			int num = 0;
			if (!profile.TryGetValue("Player", out *(JToken?*)num) || num == 0)
			{
				return;
			}
			int num2 = 0;
			bool flag = default(bool);
			if (num == 0 || !flag || num == 0)
			{
				return;
			}
			int num3 = 0;
			bool flag2 = default(bool);
			if (num == 0 || !flag2 || num == 0)
			{
				return;
			}
			int num4 = 0;
			bool flag3 = default(bool);
			if (num == 0 || !flag3 || num == 0)
			{
				return;
			}
			int num5 = 0;
			bool flag4 = default(bool);
			if (num == 0 || !flag4 || num == 0)
			{
				return;
			}
			int num6 = 0;
			if (num == 0)
			{
				return;
			}
			Func<JToken, bool> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			if (_003C_003E9__0_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((JToken x) => string.Equals(Extensions.Value<string>((IEnumerable<>)x), "FurnitureItemType_PictureFrame"));
			}
			if (Enumerable.FirstOrDefault<JToken>((IEnumerable<>)num, (Func<, >)(object)_003C_003E9__0_) != null)
			{
			}
			bool flag5 = default(bool);
			if (!flag5)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DCF")]
		[Cpp2IlInjected.Address(RVA = "0x7B4970", Offset = "0x7B3370", VA = "0x1807B4970", Slot = "5")]
		protected override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_0059, IL_005f, IL_0065, IL_006b, IL_0071, IL_0077, IL_007d, IL_0083, IL_0089
			//IL_0022: Expected O, but got I4
			int num = 0;
			ICollection<Grid> values = (ICollection<Grid>)((MapField<TKey, TValue>)(object)profile.world_.gridCollection_.grids_).get_Values();
			if (values != null)
			{
				KeyValuePair<uint, GridObject>[] array = ((IEnumerable<>)0).ToArray<KeyValuePair<uint, GridObject>>();
				while (num >= array.Length)
				{
				}
				num += 2;
				num += num;
				if (num != 0)
				{
					ListInventory catalog = profile.player_.Catalog;
				}
				num++;
			}
			int num2 = 0;
			if (values != null)
			{
				int num3 = 0;
			}
			bool flag = default(bool);
			if (flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DD0")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public PictureFrameProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
