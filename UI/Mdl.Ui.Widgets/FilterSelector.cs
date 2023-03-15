using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui.Widgets
{
	[Cpp2IlInjected.Token(Token = "0x20009A1")]
	public abstract class FilterSelector : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20009A2")]
		public delegate void FilterChanged();

		[Cpp2IlInjected.Token(Token = "0x20009A3")]
		public delegate void FilterSelectedByUser();

		[Cpp2IlInjected.Token(Token = "0x14000080")]
		public event FilterChanged OnFilterChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6003C81")]
			[Cpp2IlInjected.Address(RVA = "0x15368C0", Offset = "0x15352C0", VA = "0x1815368C0")]
			[CompilerGenerated]
			add
			{
				FilterChanged onFilterChanged = this.OnFilterChanged;
				Delegate @delegate = Delegate.Combine(onFilterChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFilterChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003C82")]
			[Cpp2IlInjected.Address(RVA = "0x1536A00", Offset = "0x1535400", VA = "0x181536A00")]
			[CompilerGenerated]
			remove
			{
				FilterChanged onFilterChanged = this.OnFilterChanged;
				Delegate @delegate = Delegate.Remove(onFilterChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFilterChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000081")]
		public event FilterSelectedByUser OnFilterSelectedByUser
		{
			[Cpp2IlInjected.Token(Token = "0x6003C83")]
			[Cpp2IlInjected.Address(RVA = "0x1536960", Offset = "0x1535360", VA = "0x181536960")]
			[CompilerGenerated]
			add
			{
				FilterSelectedByUser onFilterSelectedByUser = this.OnFilterSelectedByUser;
				Delegate @delegate = Delegate.Combine(onFilterSelectedByUser, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFilterSelectedByUser)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6003C84")]
			[Cpp2IlInjected.Address(RVA = "0x1536AA0", Offset = "0x15354A0", VA = "0x181536AA0")]
			[CompilerGenerated]
			remove
			{
				FilterSelectedByUser onFilterSelectedByUser = this.OnFilterSelectedByUser;
				Delegate @delegate = Delegate.Remove(onFilterSelectedByUser, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onFilterSelectedByUser)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003C85")]
		[Cpp2IlInjected.Address(RVA = "0x998E10", Offset = "0x997810", VA = "0x180998E10")]
		protected void RaiseFilterChanged()
		{
			this.OnFilterChanged?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C86")]
		[Cpp2IlInjected.Address(RVA = "0x1536880", Offset = "0x1535280", VA = "0x181536880")]
		protected void RaiseFilterSelectedByUser()
		{
			this.OnFilterSelectedByUser?.Invoke();
			this.OnFilterChanged?.Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x6003C87")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void SelectFilters(HashSet<Filter> filters);

		[Cpp2IlInjected.Token(Token = "0x6003C88")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract HashSet<Filter> CurrentFilters();

		[Cpp2IlInjected.Token(Token = "0x6003C89")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		protected FilterSelector()
		{
		}
	}
}
