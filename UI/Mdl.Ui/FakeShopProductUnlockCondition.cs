using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Mdl.Systems;
using Meta;
using Meta.Online;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20006CE")]
	public class FakeShopProductUnlockCondition
	{
		[Cpp2IlInjected.Token(Token = "0x20006CF")]
		public enum Type
		{
			[Cpp2IlInjected.Token(Token = "0x400266E")]
			PlayerLevel = 1,
			[Cpp2IlInjected.Token(Token = "0x400266F")]
			FriendCount = 2,
			[Cpp2IlInjected.Token(Token = "0x4002670")]
			Hour = 4,
			[Cpp2IlInjected.Token(Token = "0x4002671")]
			DayOfWeek = 8,
			[Cpp2IlInjected.Token(Token = "0x4002672")]
			DayOfMonth = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4002673")]
			MonthOfYear = 0x20,
			[Cpp2IlInjected.Token(Token = "0x4002674")]
			Year = 0x40,
			[Cpp2IlInjected.Token(Token = "0x4002675")]
			RequestInProgress = 0x80,
			[Cpp2IlInjected.Token(Token = "0x4002676")]
			RequestCompleted = 0x100,
			[Cpp2IlInjected.Token(Token = "0x4002677")]
			UnlockCharacter = 0x200,
			[Cpp2IlInjected.Token(Token = "0x4002678")]
			LockCharacter = 0x400,
			[Cpp2IlInjected.Token(Token = "0x4002679")]
			PurchaseCount = 0x800
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400266A")]
		public Type ConditionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400266B")]
		public int ConditionValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400266C")]
		public bool IsPreviewAvailable;

		[Cpp2IlInjected.Token(Token = "0x6002BBF")]
		[Cpp2IlInjected.Address(RVA = "0x152F180", Offset = "0x152DB80", VA = "0x18152F180")]
		public bool CanBeShown(FakeShopProductModel productModel)
		{
			bool isPreviewAvailable = IsPreviewAvailable;
			if (!isPreviewAvailable)
			{
				return IsUnlocked(productModel);
			}
			return isPreviewAvailable;
		}

		[Cpp2IlInjected.Token(Token = "0x6002BC0")]
		[Cpp2IlInjected.Address(RVA = "0x152F1A0", Offset = "0x152DBA0", VA = "0x18152F1A0")]
		public bool IsUnlocked(FakeShopProductModel productModel)
		{
			int num = 0;
			int num2 = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null && _003CInstance_003Ek__BackingField.MetaClient != null)
			{
				Client metaClient = SystemRoot.Instance.MetaClient;
				Type conditionType = ConditionType;
				if (conditionType > Type.Year)
				{
					if (conditionType > Type.RequestCompleted)
					{
						if (conditionType == Type.UnlockCharacter)
						{
							Profile profile = metaClient.profile;
							if (profile != null)
							{
								ProfileWorld world_ = profile.world_;
								int conditionValue = ConditionValue;
								Character character = default(Character);
								if (character != null)
								{
									bool isUnlocked = character.IsUnlocked;
								}
								return num == 1;
							}
						}
						else
						{
							bool flag = default(bool);
							if (conditionType == Type.LockCharacter)
							{
								Profile profile2 = metaClient.profile;
								if (profile2 != null)
								{
									ProfileWorld world_2 = profile2.world_;
									int conditionValue2 = ConditionValue;
									Character character2 = default(Character);
									return character2?.IsUnlocked ?? flag;
								}
							}
							if (!flag)
							{
								FakeData fakeData = default(FakeData);
								if (FakeData._instance == null)
								{
									fakeData = (FakeData._instance = new FakeData());
								}
								List<KeyValuePair<int, DateTime>> _003CPurchaseHistoryList_003Ek__BackingField = fakeData.FakeBundlePurchaseHistory.PurchaseHistoryList;
								Func<KeyValuePair<int, DateTime>, bool> func = (Func<KeyValuePair<int, DateTime>, bool>)(object)(Func<T, TResult>)delegate
								{
									//Discarded unreachable code: IL_000e
									int fakeUniqueID = productModel.FakeUniqueID;
									bool result2 = default(bool);
									return result2;
								};
								int num3 = Enumerable.Count<KeyValuePair<int, DateTime>>((IEnumerable<>)_003CPurchaseHistoryList_003Ek__BackingField, (Func<, >)(object)func);
								bool result = default(bool);
								return result;
							}
						}
					}
				}
				else if (conditionType > Type.DayOfWeek)
				{
					int num4 = default(int);
					if (conditionType == Type.DayOfMonth)
					{
						DateTime localTime = metaClient.LocalTime;
						num4 = 0;
						int num5 = default(int);
						return num5 == ConditionValue;
					}
					int num6 = default(int);
					if (num4 == 32)
					{
						num6 = 0;
						int num7 = default(int);
						return num7 == ConditionValue;
					}
					if (num6 == 64)
					{
						int num8 = 0;
						int num9 = default(int);
						return num9 == ConditionValue;
					}
				}
				else if (uint.MaxValue != 0 && uint.MaxValue != 0)
				{
					if (uint.MaxValue != 0)
					{
						if (-1L == 1L)
						{
							int num10 = default(int);
							return num10 == ConditionValue;
						}
						int num8 = default(int);
						DayOfWeek dayOfWeek = default(DayOfWeek);
						if (num8 == 8)
						{
							return dayOfWeek == (DayOfWeek)ConditionValue;
						}
					}
				}
				else
				{
					int conditionValue3 = ConditionValue;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002BC1")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public FakeShopProductUnlockCondition()
		{
		}
	}
}
