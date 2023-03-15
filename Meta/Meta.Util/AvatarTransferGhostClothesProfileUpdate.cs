using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AD9")]
	internal class AvatarTransferGhostClothesProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D76")]
		[Cpp2IlInjected.Address(RVA = "0x1AB3F20", Offset = "0x1AB2920", VA = "0x181AB3F20", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_0175
			int num = 0;
			bool flag = default(bool);
			if (!flag || "Player" == null)
			{
				return;
			}
			int num2 = 0;
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			if ("Player" == null || !flag2 || !flag3 || !flag4 || "ListInventories" == null)
			{
				return;
			}
			int num3 = 0;
			bool flag5 = default(bool);
			string text = default(string);
			if ("ListInventories" == null || !flag5 || text == null)
			{
				return;
			}
			int num4 = 0;
			bool flag6 = default(bool);
			if (text == null || !flag6)
			{
				return;
			}
			if ((object)typeof(JObject).TypeHandle == null)
			{
			}
			int num5 = 0;
			bool flag7 = default(bool);
			if (flag7 && "FemaleAvatar" != null)
			{
				int num6 = 0;
				bool flag8 = default(bool);
				if ("FemaleAvatar" != null && flag8 && "IncompatibleClothes" != null)
				{
					int num7 = 0;
					if ("IncompatibleClothes" != null)
					{
						IEnumerable<JProperty> cpp2il__autoParamName__idx_ = default(IEnumerable<JProperty>);
						JProperty[] array = ((IEnumerable<>)cpp2il__autoParamName__idx_).ToArray<JProperty>();
						int length = array.Length;
						if (num < length)
						{
							JProperty jProperty = array[num];
							string text2 = ((int*)Extensions.Value<int>((IEnumerable<>)jProperty.Value))->ToString();
							bool flag9 = default(bool);
							if (!flag9)
							{
								string name = jProperty._name;
								int num8 = 0;
							}
							num++;
						}
					}
				}
			}
			bool flag10 = default(bool);
			if (!flag10 || "MaleAvatar" == null)
			{
				return;
			}
			int num9 = 0;
			bool flag11 = default(bool);
			if ("MaleAvatar" == null || !flag11 || "IncompatibleClothes" == null)
			{
				return;
			}
			int num10 = 0;
			if ("IncompatibleClothes" == null)
			{
				return;
			}
			IEnumerable<JProperty> cpp2il__autoParamName__idx_2 = default(IEnumerable<JProperty>);
			JProperty[] array2 = ((IEnumerable<>)cpp2il__autoParamName__idx_2).ToArray<JProperty>();
			int length2 = array2.Length;
			if (num < length2)
			{
				JProperty jProperty2 = array2[num];
				string text3 = ((int*)Extensions.Value<int>((IEnumerable<>)jProperty2.Value))->ToString();
				bool flag12 = default(bool);
				if (!flag12)
				{
					string name2 = jProperty2._name;
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D77")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public AvatarTransferGhostClothesProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
