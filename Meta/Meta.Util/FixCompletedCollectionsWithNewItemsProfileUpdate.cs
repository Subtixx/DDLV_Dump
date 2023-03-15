using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Meta.Collections;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AF5")]
	internal class FixCompletedCollectionsWithNewItemsProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005DBE")]
		[Cpp2IlInjected.Address(RVA = "0x1801650", Offset = "0x1800050", VA = "0x181801650", Slot = "5")]
		protected unsafe override void DoApplyProfile(Profile profile)
		{
			//Discarded unreachable code: IL_011c, IL_0122, IL_0128, IL_012e, IL_0134, IL_013a, IL_0140, IL_0146, IL_014c, IL_0152, IL_0158, IL_015e, IL_0164, IL_016a, IL_0170, IL_0176, IL_017c, IL_0182
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			RepeatedField<CollectionSet> collectionSets_ = profile.player_.collectionSets_;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			bool flag2 = default(bool);
			if (flag2)
			{
				if (_003C_003Ec._003C_003E9__0_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				bool flag3 = default(bool);
				while (flag3)
				{
				}
				if (_003C_003Ec._003C_003E9__0_1 == null)
				{
					bool result = default(bool);
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((KeyValuePair<int, bool> x) => result);
				}
				Func<KeyValuePair<int, bool>, Item> func = default(Func<KeyValuePair<int, bool>, Item>);
				if (_003C_003Ec._003C_003E9__0_2 == null)
				{
					func = (Func<KeyValuePair<int, bool>, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(KeyValuePair<int, bool> x)
					{
						//IL_0007: Expected I4, but got O
						int num7 = (int)((KeyValuePair<, >*)(&x))->key;
						return (Item)typeof(Item).TypeHandle;
					});
				}
				IEnumerable<KeyValuePair<int, bool>> enumerable = default(IEnumerable<KeyValuePair<int, bool>>);
				Item[] array = Enumerable.Select<KeyValuePair<int, bool>, Item>((IEnumerable<>)enumerable, (Func<, >)(object)func).ToArray<Item>();
				int length = array.Length;
				int num4 = 0;
				if (num4 < array.Length)
				{
					Item item = array[num4];
					bool flag4 = default(bool);
					if (flag4)
					{
						ICollection<> collection = default(ICollection<>);
						if (collection != null)
						{
							bool flag5 = default(bool);
							while (!flag5)
							{
							}
							num3++;
						}
						num3++;
						if (collection != null)
						{
						}
						if (num3 != 0)
						{
							num4++;
						}
					}
					ICollection<> collection2 = default(ICollection<>);
					int num5 = default(int);
					if (collection2 != null)
					{
						bool flag6 = default(bool);
						while (!flag6)
						{
						}
						bool flag7 = default(bool);
						while (!flag7)
						{
						}
						num5++;
					}
					num5++;
					if (collection2 != null)
					{
					}
					if (num5 != 0)
					{
						int num6 = num5 - 1;
					}
					num4++;
				}
				while (length <= 0)
				{
				}
			}
			num3++;
			while (num3 == 0)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005DBF")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public FixCompletedCollectionsWithNewItemsProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
