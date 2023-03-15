using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PlayFab;
using PlayFab.EconomyModels;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public static class InventoryItemExt
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public class GetRecipeItemResult
		{
			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public string Id
			{
				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			public CatalogItem Item
			{
				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CItem_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CItem_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B3")]
			public PlayFabError PlayFabError
			{
				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public GetRecipeItemResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x1031750", Offset = "0x1030150", VA = "0x181031750")]
		public static InventoryItem Init(this InventoryItem self, string id, string type, InventoryItem item)
		{
			//Discarded unreachable code: IL_007d
			//IL_001f: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0031: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			self.Id = id;
			self.Type = type;
			if (item != null)
			{
			}
			self.InstanceId = (string)num3;
			if (item != null)
			{
			}
			self.StackId = (string)num3;
			self.DisplayProperties = num3;
			if (item != null)
			{
				Dictionary<string, object> displayProperties = (Dictionary<string, object>)(object)InventoryItemExt.GetDisplayProperties(item);
			}
			Dictionary<string, object> dictionary = default(Dictionary<string, object>);
			if (num3 == 0)
			{
				dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
			}
			int amount = default(int);
			if (item != null && item.Properties != null)
			{
				bool flag = default(bool);
				if (flag)
				{
					throw new NullReferenceException();
				}
				amount = 0;
			}
			if (((Dictionary<TKey, TValue>)(object)dictionary).Count > 0)
			{
			}
			int num4 = 0;
			self.Amount = amount;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x1031A60", Offset = "0x1030460", VA = "0x181031A60")]
		public static InventoryItem Init(this InventoryItem self, CatalogItem catalogItem, InventoryItem item)
		{
			//Discarded unreachable code: IL_0018
			string type = catalogItem.Type;
			string id = catalogItem.Id;
			return self.Init(id, type, item);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x10309A0", Offset = "0x102F3A0", VA = "0x1810309A0")]
		public static InventoryItem Add(this InventoryItem self, int amount)
		{
			//Discarded unreachable code: IL_0002
			return self;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x1032370", Offset = "0x1030D70", VA = "0x181032370")]
		public static InventoryItem Remove(this InventoryItem self, int amount)
		{
			//Discarded unreachable code: IL_0002
			return self;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x10309C0", Offset = "0x102F3C0", VA = "0x1810309C0")]
		public static Dictionary<string, object> GetDisplayProperties(this InventoryItem self)
		{
			//Discarded unreachable code: IL_006f, IL_0075, IL_007b, IL_0081, IL_0087
			int num = 0;
			IEnumerable<JProperty> enumerable;
			if ((IntPtr)self.DisplayProperties != (IntPtr)num)
			{
				JObject jObject = JObject.FromObject(self.DisplayProperties);
				if (jObject != null)
				{
					Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
					enumerable = (IEnumerable<JProperty>)jObject.Properties();
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						if (num == (int)num2)
						{
							goto IL_005f;
						}
						num++;
					}
					if (enumerable != null)
					{
						uint num3 = default(uint);
						if (num < (int)num3)
						{
							num += num;
							if (num == (int)num3)
							{
								goto IL_005f;
							}
							num++;
						}
						JToken jToken = default(JToken);
						string text = jToken.ToString();
						throw new NullReferenceException();
					}
					goto IL_005f;
				}
				goto IL_0063;
			}
			goto IL_0066;
			IL_0066:
			int num4 = 0;
			throw new NullReferenceException();
			IL_005f:
			if (enumerable == null)
			{
			}
			goto IL_0063;
			IL_0063:
			int num5 = 0;
			goto IL_0066;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x10311B0", Offset = "0x102FBB0", VA = "0x1810311B0")]
		public unsafe static string GetProperty(this InventoryItem self, string propName)
		{
			int num = 0;
			Dictionary<string, string> properties = self.Properties;
			if (properties != null && ((Dictionary<TKey, TValue>)(object)properties).TryGetValue((TKey)propName, out *(TValue*)num))
			{
				char[] array = new char[2];
				int length = array.Length;
				array[0] = '\\';
				array[0] = '"';
				string result = default(string);
				return result;
			}
			if ((long)self.DisplayProperties != 0)
			{
				JObject jObject = JObject.FromObject(self.DisplayProperties);
				if (jObject != null && jObject.TryGetValue(propName, out *(JToken?*)num))
				{
					char[] array2 = new char[2];
					int length2 = array2.Length;
					array2[0] = '\\';
					array2[0] = '"';
					return ((int*)num)->ToString().Trim(array2);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x10313B0", Offset = "0x102FDB0", VA = "0x1810313B0")]
		public static bool GetProperty(this InventoryItem self, string propName, out DateTime propValue)
		{
			//IL_001c: Expected I8, but got O
			string property = self.GetProperty(propName);
			bool flag = default(bool);
			if (!flag)
			{
				DateTime minValue = DateTime.MinValue;
				int num = 0;
				propValue.dateData = (ulong)(long)minValue;
			}
			ulong dateData = default(ulong);
			propValue.dateData = dateData;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1032430", Offset = "0x1030E30", VA = "0x181032430")]
		public static void SetProperty(this InventoryItem self, string propName, string propValue)
		{
			//Discarded unreachable code: IL_0029, IL_0031
			if ((long)self.DisplayProperties == 0)
			{
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(self.DisplayProperties = new Dictionary<TKey, TValue>());
			}
			Dictionary<string, object> displayProperties = (Dictionary<string, object>)(object)InventoryItemExt.GetDisplayProperties(self);
			if (displayProperties != null)
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1031C10", Offset = "0x1030610", VA = "0x181031C10")]
		public static bool IsContentTypeSet(this InventoryItem self)
		{
			return !string.IsNullOrEmpty(self.GetProperty("content"));
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1031AA0", Offset = "0x10304A0", VA = "0x181031AA0")]
		public static bool IsContentTypeIn(this InventoryItem self, List<string> contentTypes)
		{
			string contentType = self.GetProperty("content");
			if (string.IsNullOrEmpty(contentType))
			{
				if (string.IsNullOrEmpty(self.Origin))
				{
					int num = 0;
				}
				Func<string, bool> func = (Func<string, bool>)(object)(Func<T, TResult>)delegate(string x)
				{
					string b2 = contentType;
					return string.Equals(x, b2);
				};
			}
			Func<string, bool> cpp2il__autoParamName__idx_ = (Func<string, bool>)(object)(Func<T, TResult>)delegate(string x)
			{
				string b = contentType;
				return string.Equals(x, b);
			};
			bool flag = ((IEnumerable<>)contentTypes).Any<string>((Func<, >)(object)cpp2il__autoParamName__idx_);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1031170", Offset = "0x102FB70", VA = "0x181031170")]
		public static string GetLinkItemId(this InventoryItem self)
		{
			return self.GetProperty("linkid");
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1031F50", Offset = "0x1030950", VA = "0x181031F50")]
		public static bool IsNotStarted(this InventoryItem self)
		{
			string property;
			do
			{
				property = self.GetProperty("notstarted");
			}
			while (property == null);
			return property.IsTrue();
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1031E00", Offset = "0x1030800", VA = "0x181031E00")]
		public static bool IsHidden(this InventoryItem self)
		{
			string property;
			do
			{
				property = self.GetProperty("hidden");
			}
			while (property == null);
			return property.IsTrue();
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1031E60", Offset = "0x1030860", VA = "0x181031E60")]
		public static bool IsMailboxKey(this InventoryItem self)
		{
			//Discarded unreachable code: IL_0038
			string property = self.GetProperty("content");
			if (string.IsNullOrEmpty(property))
			{
				if (string.IsNullOrEmpty(self.Origin))
				{
					int num = 0;
				}
				return PlayFabContentType.IsOriginMailboxKey(self.Origin);
			}
			return PlayFabContentType.IsMailboxKey(property);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1031FB0", Offset = "0x10309B0", VA = "0x181031FB0")]
		public static bool IsPremiumActive(this InventoryItem self)
		{
			string property;
			do
			{
				property = self.GetProperty("ispremium");
			}
			while (property == null);
			return property.IsTrue();
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1032390", Offset = "0x1030D90", VA = "0x181032390")]
		public static void SetIsPremiumActive(this InventoryItem self, bool isActive)
		{
			string propValue = default(string);
			self.SetProperty("ispremium", propValue);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1032010", Offset = "0x1030A10", VA = "0x181032010")]
		public static bool IsPremiumBundleBought(this InventoryItem self)
		{
			string property;
			do
			{
				property = self.GetProperty("bundlebought");
			}
			while (property == null);
			return property.IsTrue();
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x10323E0", Offset = "0x1030DE0", VA = "0x1810323E0")]
		public static void SetPremiumBundleBought(this InventoryItem self, bool isBought)
		{
			string propValue = default(string);
			self.SetProperty("bundlebought", propValue);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x19AD860", Offset = "0x19AC260", VA = "0x1819AD860")]
		public static bool TryDeserializeProperties<T>(this InventoryItem P_0, string P_1, out T value) where T : class
		{
			while (true)
			{
				int num = 0;
				if (P_0.GetProperty(P_1) != null)
				{
					/*Error: Could not find block for branch target IL_000c*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1030F00", Offset = "0x102F900", VA = "0x181030F00")]
		public static IEnumerable<bool> GetEventTaskCollectedStatus(this InventoryItem self)
		{
			bool flag = default(bool);
			if (flag)
			{
				if (_003C_003Ec._003C_003E9__19_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((EventTaskStatus x) => x == EventTaskStatus.Collected);
				}
				IEnumerable<EventTaskStatus> result = default(IEnumerable<EventTaskStatus>);
				return (IEnumerable<bool>)result;
			}
			List<bool> list = (List<bool>)(object)new List<T>();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x10326B0", Offset = "0x10310B0", VA = "0x1810326B0")]
		public unsafe static bool TrySetEventTaskCollected(this InventoryItem self, int taskIdx, [Optional] int? initTaskCountIfEmpty)
		{
			//IL_002a: Expected O, but got I4
			int num = 0;
			if (!self.TryDeserializeProperties<List<EventTaskStatus>>("tasks", out *(List<EventTaskStatus>*)num))
			{
				int num2 = default(int);
				List<EventTaskStatus> list = (List<EventTaskStatus>)(object)Enumerable.ToList<EventTaskStatus>(Enumerable.Repeat<EventTaskStatus>(EventTaskStatus.NotCollected, num2));
			}
			if (num == 0)
			{
				int num3 = 0;
			}
			string propValue = JsonConvert.SerializeObject(num);
			self.SetProperty("tasks", propValue);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1030C90", Offset = "0x102F690", VA = "0x181030C90")]
		public static IEnumerable<bool> GetEventRewardPurchasedStatus(this InventoryItem self)
		{
			bool flag = default(bool);
			if (flag)
			{
				if (_003C_003Ec._003C_003E9__21_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((EventRewardStatus x) => x == EventRewardStatus.Purchased);
				}
				IEnumerable<EventRewardStatus> result = default(IEnumerable<EventRewardStatus>);
				return (IEnumerable<bool>)result;
			}
			List<bool> list = (List<bool>)(object)new List<T>();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1032530", Offset = "0x1030F30", VA = "0x181032530")]
		public unsafe static bool TrySetEventRewardPurchased(this InventoryItem self, int rewardIdx, [Optional] int? initRewardCountIfEmpty)
		{
			//IL_002a: Expected O, but got I4
			int num = 0;
			if (!self.TryDeserializeProperties<List<EventRewardStatus>>("rewards", out *(List<EventRewardStatus>*)num))
			{
				int num2 = default(int);
				List<EventRewardStatus> list = (List<EventRewardStatus>)(object)Enumerable.ToList<EventRewardStatus>(Enumerable.Repeat<EventRewardStatus>(EventRewardStatus.NotPurchased, num2));
			}
			if (num == 0)
			{
				int num3 = 0;
			}
			string propValue = JsonConvert.SerializeObject(num);
			self.SetProperty("rewards", propValue);
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1031D30", Offset = "0x1030730", VA = "0x181031D30")]
		public static bool IsEventTaskCollected(this InventoryItem self, int taskIdx)
		{
			//Discarded unreachable code: IL_001e
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				return (long)"tasks" == 1;
			}
			return 2L == 1L;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x10310B0", Offset = "0x102FAB0", VA = "0x1810310B0")]
		public static EventTaskStatus GetEventTaskStatus(this InventoryItem self, int taskIdx)
		{
			//Discarded unreachable code: IL_000d
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return EventTaskStatus.NotFound;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x10321F0", Offset = "0x1030BF0", VA = "0x1810321F0")]
		public static int NumTasksCollected(this InventoryItem self)
		{
			bool flag = default(bool);
			if (flag)
			{
				if (_003C_003Ec._003C_003E9__25_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((EventTaskStatus x) => x == EventTaskStatus.Collected);
				}
				int result = default(int);
				return result;
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1031C60", Offset = "0x1030660", VA = "0x181031C60")]
		public static bool IsEventRewardPurchased(this InventoryItem self, int rewardIdx)
		{
			//Discarded unreachable code: IL_001e
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
				return (long)"rewards" == 1;
			}
			return 2L == 1L;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1030E40", Offset = "0x102F840", VA = "0x181030E40")]
		public static EventRewardStatus GetEventRewardStatus(this InventoryItem self, int rewardIdx)
		{
			//Discarded unreachable code: IL_000d
			bool flag = default(bool);
			if (flag)
			{
				int num = 0;
				System.ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return EventRewardStatus.NotFound;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1032070", Offset = "0x1030A70", VA = "0x181032070")]
		public static int NumRewardsPurchased(this InventoryItem self)
		{
			bool flag = default(bool);
			if (flag)
			{
				if (_003C_003Ec._003C_003E9__28_0 == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((EventRewardStatus x) => x == EventRewardStatus.Purchased);
				}
				int result = default(int);
				return result;
			}
			return 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1031490", Offset = "0x102FE90", VA = "0x181031490")]
		[AsyncStateMachine(typeof(_003CGetRecipeItemFromKey_003Ed__30))]
		public static Task<GetRecipeItemResult> GetRecipeItemFromKey(this InventoryItem self, PlayFabEconomyInstanceAPI economy, EntityKey entity)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<GetRecipeItemResult>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x10315F0", Offset = "0x102FFF0", VA = "0x1810315F0")]
		[AsyncStateMachine(typeof(_003CGetRecipeItemIdFromKey_003Ed__31))]
		public static Task<string> GetRecipeItemIdFromKey(this InventoryItem self, PlayFabEconomyInstanceAPI economy, EntityKey entity)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<string>)(object)result;
		}
	}
}
