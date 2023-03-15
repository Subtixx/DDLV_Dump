using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using NodeCanvas.DialogueTrees.Gameloft.Flux;
using ParadoxNotion.Design;

namespace Assets.Scripts.Requests.Actions
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[Icon("Dialogue", false, "")]
	[Description("(Ctrl-Shift-Y) Turn flags ON/OFF")]
	[Category("Mdl")]
	public class SetDialogueFlags : MdlActionTaskAsync, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		public class Config
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000663")]
			public ItemFlagFiltering flag;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000664")]
			public bool active = true;

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x143FFE0", Offset = "0x143E9E0", VA = "0x18143FFE0")]
			public string GetInfo()
			{
				ItemFlagFiltering itemFlagFiltering = flag;
				string result = default(string);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x143FFF0", Offset = "0x143E9F0", VA = "0x18143FFF0")]
			public static string GetInfo(List<Config> flags)
			{
				if (flags != null)
				{
					Func<Config, bool> _003C_003E9__3_ = _003C_003Ec._003C_003E9__3_0;
					if (_003C_003E9__3_ == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Config x) => default(bool));
					}
					IEnumerable<Config> enumerable = (IEnumerable<Config>)Enumerable.Where<Config>((IEnumerable<>)flags, (Func<, >)(object)_003C_003E9__3_);
					Func<Config, string> func = default(Func<Config, string>);
					if (_003C_003Ec._003C_003E9__3_1 == null)
					{
						func = (Func<Config, string>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Config x) => null));
					}
					IEnumerable<Config> enumerable2 = (IEnumerable<Config>)Enumerable.Select<Config, string>((IEnumerable<>)enumerable, (Func<, >)(object)func);
					return string.Join("\n+\n", (IEnumerable<>)enumerable2);
				}
				return "";
			}

			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x143FEB0", Offset = "0x143E8B0", VA = "0x18143FEB0")]
			public static Dictionary<int, bool> GetFlagChanges(List<Config> flags)
			{
				//Discarded unreachable code: IL_0032
				_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
				Dictionary<int, bool> dictionary = (CS_0024_003C_003E8__locals0.changes = (Dictionary<int, bool>)(object)new Dictionary<TKey, TValue>());
				if (flags != null)
				{
					Action<Config> action = (Action<Config>)(object)(Action<T>)delegate
					{
					};
					((List<T>)(object)flags).ForEach((Action<>)(object)action);
				}
				return CS_0024_003C_003E8__locals0.changes;
			}

			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x1440250", Offset = "0x143EC50", VA = "0x181440250")]
			public Config()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public List<Config> flags = (List<Config>)(object)new List<T> { (T)new Config() };

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override string info
		{
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0xF4AA70", Offset = "0xF49470", VA = "0x180F4AA70", Slot = "9")]
			get
			{
				string prefix = Config.GetInfo((List<>)(object)flags);
				return AddErrors(prefix);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0xF4A890", Offset = "0xF49290", VA = "0x180F4A890", Slot = "18")]
		[AsyncStateMachine(typeof(_003CDoActionAsync_003Ed__4))]
		protected override Task DoActionAsync()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0xF4A540", Offset = "0xF48F40", VA = "0x180F4A540", Slot = "20")]
		public void DataValidation(DataValidation.Context context)
		{
			List<Config> list = flags;
			if (list != null && Enumerable.Any<Config>((IEnumerable<>)list))
			{
				List<Config> cpp2il__autoParamName__idx_ = flags;
				Func<Config, bool> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
				if (_003C_003E9__5_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Config x) => (x == null) ? true : ((byte)(int)typeof(Item).TypeHandle != 0));
				}
				if (!((IEnumerable<>)cpp2il__autoParamName__idx_).Any<Config>((Func<, >)(object)_003C_003E9__5_))
				{
					List<Config> list2 = flags;
					Func<Config, Item> func = default(Func<Config, Item>);
					if (_003C_003Ec._003C_003E9__5_1 == null)
					{
						func = (Func<Config, Item>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Config x)
						{
							ItemFlagFiltering flag = x.flag;
							throw new NullReferenceException();
						});
					}
					int num = Enumerable.Count<Item>(Enumerable.Distinct<Item>(Enumerable.Select<Config, Item>((IEnumerable<>)list2, (Func<, >)(object)func)));
					List<Config> list3 = flags;
					context.AddInvalidMemberError("Contain duplicate items", "flags");
					return;
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0xF4A990", Offset = "0xF49390", VA = "0x180F4A990")]
		public SetDialogueFlags()
		{
		}//Discarded unreachable code: IL_0021

	}
}
