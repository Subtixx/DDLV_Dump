using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Ftue.Steps;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Ftue.Cutscenes
{
	[Cpp2IlInjected.Token(Token = "0x20005C4")]
	public class CustomTimelineCutscene : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20005C5")]
		public struct ItemHolder
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002387")]
			public string holderID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4002388")]
			[SerializeField]
			[ItemID]
			public int itemID;

			[Cpp2IlInjected.Token(Token = "0x170003B1")]
			public Item Item
			{
				[Cpp2IlInjected.Token(Token = "0x60019C7")]
				[Cpp2IlInjected.Address(RVA = "0x1196640", Offset = "0x1195040", VA = "0x181196640")]
				get
				{
					long num = Convert.ToInt64((uint)itemID);
					/*Error: Unexpected end of block*/;
				}
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20005C6")]
		public struct ItemPrefabMap
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002389")]
			[SerializeField]
			[ItemID]
			public int itemID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400238A")]
			public GameObject prefabItem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400238B")]
			[SerializeField]
			[ItemID]
			public List<int> conditionsItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400238C")]
			[SerializeField]
			[ItemID]
			public int flagToSet;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400237D")]
		[SerializeField]
		[Header("Cutscene")]
		private PlayCutscene cutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400237E")]
		[SerializeField]
		private bool useOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400237F")]
		[SerializeField]
		private string thisObjectHolderID = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002380")]
		[SerializeField]
		private List<ItemHolder> customItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002381")]
		[SerializeField]
		private List<ItemPrefabMap> itemPrefabMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002382")]
		[SerializeField]
		[ItemID]
		private int setFlagCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002383")]
		[SerializeField]
		[ItemID]
		private int setFlagAfterCutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002384")]
		private Dictionary<string, Item> customItemsDic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4002385")]
		private Dictionary<int, GameObject> itemToPrefabDic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002386")]
		private Dictionary<string, string> trackTextDic;

		[Cpp2IlInjected.Token(Token = "0x170003AE")]
		public List<ItemPrefabMap> ItemPrefabMapList
		{
			[Cpp2IlInjected.Token(Token = "0x60019BF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return itemPrefabMap;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003AF")]
		private Dictionary<string, Item> CustomItemsDic
		{
			[Cpp2IlInjected.Token(Token = "0x60019C0")]
			[Cpp2IlInjected.Address(RVA = "0x110F770", Offset = "0x110E170", VA = "0x18110F770")]
			get
			{
				Dictionary<string, Item> dictionary = customItemsDic;
				if (dictionary == null)
				{
					List<ItemHolder> list = customItems;
					Func<ItemHolder, string> _003C_003E9__13_ = _003C_003Ec._003C_003E9__13_0;
					if (_003C_003E9__13_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
						};
					}
					Func<ItemHolder, Item> func = default(Func<ItemHolder, Item>);
					if (_003C_003Ec._003C_003E9__13_1 == null)
					{
						func = (Func<ItemHolder, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ItemHolder x)
						{
							int itemID = x.itemID;
							return (Item)typeof(Item).TypeHandle;
						});
					}
					Dictionary<ItemHolder, string> dictionary2 = (Dictionary<ItemHolder, string>)(object)(customItemsDic = (Dictionary<string, Item>)(object)Enumerable.ToDictionary<ItemHolder, string, Item>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__13_, (Func<, >)(object)func));
				}
				return dictionary;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B0")]
		private Dictionary<int, GameObject> ItemPrefabMapDic
		{
			[Cpp2IlInjected.Token(Token = "0x60019C1")]
			[Cpp2IlInjected.Address(RVA = "0x110F9A0", Offset = "0x110E3A0", VA = "0x18110F9A0")]
			get
			{
				Dictionary<int, GameObject> dictionary = itemToPrefabDic;
				if (dictionary == null)
				{
					List<ItemPrefabMap> list = itemPrefabMap;
					Func<ItemPrefabMap, int> _003C_003E9__16_ = _003C_003Ec._003C_003E9__16_0;
					if (_003C_003E9__16_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
						};
					}
					Func<ItemPrefabMap, GameObject> func = default(Func<ItemPrefabMap, GameObject>);
					if (_003C_003Ec._003C_003E9__16_1 == null)
					{
						func = (Func<ItemPrefabMap, GameObject>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
						{
							throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
						});
					}
					Dictionary<ItemPrefabMap, int> dictionary2 = (Dictionary<ItemPrefabMap, int>)(object)(itemToPrefabDic = (Dictionary<int, GameObject>)(object)Enumerable.ToDictionary<ItemPrefabMap, int, GameObject>((IEnumerable<>)list, (Func<, >)(object)_003C_003E9__16_, (Func<, >)(object)func));
				}
				return dictionary;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60019C2")]
		[Cpp2IlInjected.Address(RVA = "0x110F500", Offset = "0x110DF00", VA = "0x18110F500")]
		public void SetCustomItems(List<ItemHolder> items)
		{
			Func<ItemHolder, string> _003C_003E9__18_ = _003C_003Ec._003C_003E9__18_0;
			if (_003C_003E9__18_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			Func<ItemHolder, Item> func = default(Func<ItemHolder, Item>);
			if (_003C_003Ec._003C_003E9__18_1 == null)
			{
				func = (Func<ItemHolder, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(ItemHolder x)
				{
					int itemID = x.itemID;
					return (Item)typeof(Item).TypeHandle;
				});
			}
			Dictionary<ItemHolder, string> dictionary = (Dictionary<ItemHolder, string>)(object)(customItemsDic = (Dictionary<string, Item>)(object)Enumerable.ToDictionary<ItemHolder, string, Item>((IEnumerable<>)items, (Func<, >)(object)_003C_003E9__18_, (Func<, >)(object)func));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60019C3")]
		[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
		public void SetCustomtext(Dictionary<string, string> textTracks)
		{
			trackTextDic = textTracks;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60019C4")]
		[Cpp2IlInjected.Address(RVA = "0x110F3D0", Offset = "0x110DDD0", VA = "0x18110F3D0")]
		[AsyncStateMachine(typeof(_003CPlay_003Ed__20))]
		public Task<bool> Play(int setFlag = 0)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60019C5")]
		[Cpp2IlInjected.Address(RVA = "0x110F280", Offset = "0x110DC80", VA = "0x18110F280")]
		[AsyncStateMachine(typeof(_003CCustomCSPlay_003Ed__21))]
		public Task<bool> CustomCSPlay(int setFlag = 0)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<bool>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x60019C6")]
		[Cpp2IlInjected.Address(RVA = "0x110F720", Offset = "0x110E120", VA = "0x18110F720")]
		public CustomTimelineCutscene()
		{
		}
	}
}
