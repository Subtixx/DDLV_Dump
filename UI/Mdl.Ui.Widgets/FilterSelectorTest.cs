using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009A4")]
	public class FilterSelectorTest : FilterSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40038D8")]
		public FilterColorConfig colorConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40038D9")]
		public List<FilterSelector> selectors = (List<FilterSelector>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40038DA")]
		public InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40038DB")]
		public Button selectTags;

		[Cpp2IlInjected.Token(Token = "0x6003C92")]
		[Cpp2IlInjected.Address(RVA = "0x165B470", Offset = "0x1659E70", VA = "0x18165B470")]
		private void Start()
		{
			//Discarded unreachable code: IL_003b
			Button.ButtonClickedEvent onClick = selectTags.m_OnClick;
			UnityAction call = SelectTags;
			onClick.AddListener(call);
			List<FilterSelector> list = selectors;
			bool flag = default(bool);
			if (flag)
			{
				FilterSelectedByUser filterSelectedByUser = UpdateFilters;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C93")]
		[Cpp2IlInjected.Address(RVA = "0x165B620", Offset = "0x165A020", VA = "0x18165B620")]
		private unsafe void UpdateFilters()
		{
			//Discarded unreachable code: IL_0067, IL_006d, IL_0073
			int num = 0;
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)this.CurrentFilters();
			Func<Filter, int> _003C_003E9__5_ = _003C_003Ec._003C_003E9__5_0;
			if (_003C_003E9__5_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Filter f) => f.Order);
			}
			IOrderedEnumerable<Filter> orderedEnumerable = (IOrderedEnumerable<Filter>)Enumerable.OrderBy<Filter, int>((IEnumerable<>)hashSet, (Func<, >)(object)_003C_003E9__5_);
			if (orderedEnumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_005e;
					}
					num++;
				}
				TypeCode typeCode = ((int*)num)->GetTypeCode();
				string text = default(string);
				string text2 = text + " ";
			}
			goto IL_005e;
			IL_005e:
			if (orderedEnumerable != null)
			{
				int num3 = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C94")]
		[Cpp2IlInjected.Address(RVA = "0x165B2B0", Offset = "0x1659CB0", VA = "0x18165B2B0")]
		private unsafe void SelectTags()
		{
			//Discarded unreachable code: IL_0086
			InputField inputField = this.inputField;
			int num = 0;
			string text = inputField.m_Text;
			char[] array = new char[0];
			array[0] = ' ';
			string[] array2 = text.Split(array);
			HashSet<Filter> hashSet = (HashSet<Filter>)(object)new HashSet<T>();
			int length = array2.Length;
			if (num < length)
			{
				FilterColorConfig filterColorConfig = colorConfig;
				int order = 0;
				Filter filter = FilterUtil.BuildFilter(array2[num], filterColorConfig, order);
				if (*(Filter*)filter != *(Filter*)num)
				{
					bool flag = ((HashSet<T>)(object)hashSet).Add((T)filter);
				}
				num++;
			}
			this.SelectFilters((HashSet<>)(object)hashSet);
			RaiseFilterSelectedByUser();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C95")]
		[Cpp2IlInjected.Address(RVA = "0x165B1A0", Offset = "0x1659BA0", VA = "0x18165B1A0", Slot = "4")]
		public override void SelectFilters(HashSet<Filter> filters)
		{
			//Discarded unreachable code: IL_000c
			List<FilterSelector> list = selectors;
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C96")]
		[Cpp2IlInjected.Address(RVA = "0x165B030", Offset = "0x1659A30", VA = "0x18165B030", Slot = "5")]
		public override HashSet<Filter> CurrentFilters()
		{
			//Discarded unreachable code: IL_0013, IL_0019, IL_001f
			HashSet<Filter> result = (HashSet<Filter>)(object)new HashSet<T>();
			List<FilterSelector> list = selectors;
			bool flag = default(bool);
			if (flag)
			{
			}
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6003C97")]
		[Cpp2IlInjected.Address(RVA = "0x165B930", Offset = "0x165A330", VA = "0x18165B930")]
		public FilterSelectorTest()
		{
		}
	}
}
