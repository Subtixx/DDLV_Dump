using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200067E")]
	internal class RestaurantEnvironment : Environment
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200067F")]
		public class SeatingArrangement
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400269F")]
			public int Level;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40026A0")]
			public GameObject Prefab;

			[Cpp2IlInjected.Token(Token = "0x6001CE3")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public SeatingArrangement()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400269B")]
		[SerializeField]
		private SeatingArrangement[] _seatingArrangements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400269C")]
		public GameObject RestaurantOrderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400269D")]
		private Dictionary<Item, CancellationTokenSource> restaurantOrdersCTS = (Dictionary<Item, CancellationTokenSource>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400269E")]
		private List<Mdl.Characters.Character> characters = (List<Mdl.Characters.Character>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x6001CDD")]
		[Cpp2IlInjected.Address(RVA = "0xCC24B0", Offset = "0xCC0EB0", VA = "0x180CC24B0")]
		public bool IsCustomerOfRestaurant(Item characterItem)
		{
			//Discarded unreachable code: IL_003e
			//IL_0014: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			int itemID = characterItem.ItemID;
			Item characterItem2 = (Item)itemID;
			List<Mdl.Characters.Character> list = characters;
			Predicate<Mdl.Characters.Character> predicate = (Predicate<Mdl.Characters.Character>)(object)(Predicate<T>)delegate(Mdl.Characters.Character x)
			{
				Item _003CItem_003Ek__BackingField = x.Item;
				throw new NullReferenceException();
			};
			Mdl.Characters.Character character = (Mdl.Characters.Character)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
			int num = 0;
			return character != (UnityEngine.Object)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CDE")]
		[Cpp2IlInjected.Address(RVA = "0xCC1EE0", Offset = "0xCC08E0", VA = "0x180CC1EE0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CEnterEnvironment_003Ed__6))]
		internal override Task EnterEnvironment(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CDF")]
		[Cpp2IlInjected.Address(RVA = "0xCC2050", Offset = "0xCC0A50", VA = "0x180CC2050", Slot = "7")]
		internal override Task ExitEnvironment(Profile profile, PlayerAvatar avatar, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0033, IL_0039, IL_003f, IL_0045, IL_004b, IL_0051, IL_0057
			int num = 0;
			int num2 = 0;
			List<Mdl.Characters.Character> list = characters;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
			}
			bool flag3 = default(bool);
			if (flag3)
			{
			}
			ProfileEventDispatcher.RestaurantOrderFulfilled value = default(ProfileEventDispatcher.RestaurantOrderFulfilled);
			SystemRoot.Instance.MetaClient.Dispatcher.OnRestaurantOrderFulfilled -= value;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CE0")]
		[Cpp2IlInjected.Address(RVA = "0xCC25D0", Offset = "0xCC0FD0", VA = "0x180CC25D0")]
		private void OnRestaurantOrderFulfilled(CharacterRestaurantOrder order, ItemWithState mealServed)
		{
			//Discarded unreachable code: IL_0023
			Dictionary<Item, CancellationTokenSource> dictionary = restaurantOrdersCTS;
			Item characterItem = order.CharacterItem;
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<Item, CancellationTokenSource> dictionary2 = restaurantOrdersCTS;
				Item characterItem2 = order.CharacterItem;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CE1")]
		[Cpp2IlInjected.Address(RVA = "0xCC26C0", Offset = "0xCC10C0", VA = "0x180CC26C0")]
		public RestaurantEnvironment()
		{
		}
	}
}
