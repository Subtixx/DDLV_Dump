using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta.Duties;
using Meta.Online;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000443")]
	public class DreamlightMenuModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000485")]
		internal IEnumerable<DreamlightItemModel> DreamlightItemModels
		{
			[Cpp2IlInjected.Token(Token = "0x6001B96")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CDreamlightItemModels_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001B97")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CDreamlightItemModels_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000486")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4001595")]
		public AchievementType AchievementType
		{
			[Cpp2IlInjected.Token(Token = "0x6001B98")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001B99")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001B9A")]
		[Cpp2IlInjected.Address(RVA = "0xF1BFE0", Offset = "0xF1A9E0", VA = "0x180F1BFE0")]
		internal void RefreshData()
		{
			//Discarded unreachable code: IL_01c9, IL_01cf, IL_01d5, IL_01e1, IL_01e7
			//IL_005c: Expected O, but got I4
			//IL_016d: Expected O, but got I4
			int num2;
			bool flag = default(bool);
			Func<AchievementItemModel, bool> func = default(Func<AchievementItemModel, bool>);
			Func<AchievementItemModel, bool> func2 = default(Func<AchievementItemModel, bool>);
			Func<AchievementItemModel, float> func3 = default(Func<AchievementItemModel, float>);
			int num4;
			while (true)
			{
				int num = 0;
				num2 = 0;
				int num3 = 0;
				num4 = 0;
				int num5 = 0;
				if (!Application.isPlaying)
				{
					return;
				}
				Client metaClient = SystemRoot.Instance.MetaClient;
				if (AchievementType == (AchievementType)num4)
				{
					break;
				}
				RepeatedField<AchievementData> achievementsData_ = metaClient.profile.player_.achievementsData_;
				List<AchievementItemModel> list = (List<AchievementItemModel>)(object)new List<T>();
				if (flag)
				{
					AchievementItemModel achievementItemModel = new AchievementItemModel();
					achievementItemModel.AchievementData = (AchievementData)num2;
					if (achievementItemModel.AchievementItemData.type_ != AchievementType)
					{
						continue;
					}
					((List<T>)(object)list).Add((T)achievementItemModel);
				}
				if (_003C_003Ec._003C_003E9__8_3 == null)
				{
					func = (Func<AchievementItemModel, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AchievementItemModel x) => !x.IsEnded));
				}
				IOrderedEnumerable<AchievementItemModel> orderedEnumerable = (IOrderedEnumerable<AchievementItemModel>)Enumerable.OrderByDescending<AchievementItemModel, bool>((IEnumerable<>)list, (Func<, >)(object)func);
				if (_003C_003Ec._003C_003E9__8_4 == null)
				{
					func2 = (Func<AchievementItemModel, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AchievementItemModel x) => x.NotCompleted));
				}
				IOrderedEnumerable<AchievementItemModel> orderedEnumerable2 = (IOrderedEnumerable<AchievementItemModel>)Enumerable.ThenByDescending<AchievementItemModel, bool>((IOrderedEnumerable<>)orderedEnumerable, (Func<, >)(object)func2);
				if (_003C_003Ec._003C_003E9__8_5 == null)
				{
					func3 = (Func<AchievementItemModel, float>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((AchievementItemModel x) => x.Progress));
				}
				IOrderedEnumerable<AchievementItemModel> orderedEnumerable3 = (IOrderedEnumerable<AchievementItemModel>)(DreamlightItemModels = (IEnumerable<DreamlightItemModel>)Enumerable.ThenByDescending<AchievementItemModel, float>((IOrderedEnumerable<>)orderedEnumerable2, (Func<, >)(object)func3));
				return;
			}
			Client client = default(Client);
			List<DutySlot> list2 = (List<DutySlot>)(object)Enumerable.ToList<DutySlot>((IEnumerable<>)(object)client.profile.player_.GetRoyalDutiesList().slots_);
			Predicate<DutySlot> predicate = default(Predicate<DutySlot>);
			if (_003C_003Ec._003C_003E9__8_0 == null)
			{
				predicate = (Predicate<DutySlot>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)((DutySlot x) => x != null));
			}
			RoyalDutyItemModel[] array = new RoyalDutyItemModel[((List<T>)(object)list2).FindAll((Predicate<>)(object)predicate)._size];
			bool flag2 = default(bool);
			if (flag2)
			{
				RoyalDutyItemModel royalDutyItemModel = new RoyalDutyItemModel();
				royalDutyItemModel.DutySlot = (DutySlot)num2;
				num4++;
				if (royalDutyItemModel == null)
				{
					throw new IndexOutOfRangeException();
				}
				num4 += 4;
			}
			Func<RoyalDutyItemModel, bool> func4 = default(Func<RoyalDutyItemModel, bool>);
			if (_003C_003Ec._003C_003E9__8_1 == null)
			{
				func4 = (Func<RoyalDutyItemModel, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((RoyalDutyItemModel x) => x.NotCompleted));
			}
			IOrderedEnumerable<RoyalDutyItemModel> orderedEnumerable4 = (IOrderedEnumerable<RoyalDutyItemModel>)Enumerable.OrderByDescending<RoyalDutyItemModel, bool>((IEnumerable<>)(object)array, (Func<, >)(object)func4);
			if (_003C_003Ec._003C_003E9__8_2 == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((RoyalDutyItemModel x) => x.Progress);
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001B9B")]
		[Cpp2IlInjected.Address(RVA = "0xF1BFC0", Offset = "0xF1A9C0", VA = "0x180F1BFC0")]
		internal void Dispose()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001B9C")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public DreamlightMenuModel()
		{
		}
	}
}
