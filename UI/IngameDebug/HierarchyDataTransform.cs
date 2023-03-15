using Cpp2IlInjected;
using UnityEngine;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class HierarchyDataTransform : HierarchyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private string cachedName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private bool isSearchEntry;

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public override string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0xAE4790", Offset = "0xAE3190", VA = "0x180AE4790", Slot = "4")]
			get
			{
				//Discarded unreachable code: IL_0032
				string text = cachedName;
				if (text == null)
				{
					if ((bool)transform)
					{
						string name = transform.name;
					}
					cachedName = "<destroyed>";
				}
				return text;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		public override int ChildCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xAE4660", Offset = "0xAE3060", VA = "0x180AE4660", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_0025
				if (!isSearchEntry && (bool)transform)
				{
					return transform.childCount;
				}
				return 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		public override Transform BoundTransform
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240", Slot = "7")]
			get
			{
				return transform;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		public override bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xAE46F0", Offset = "0xAE30F0", VA = "0x180AE46F0", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_0021
				if ((bool)transform)
				{
					return transform.gameObject.activeInHierarchy;
				}
				return true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xAE43D0", Offset = "0xAE2DD0", VA = "0x180AE43D0")]
		public void Initialize(Transform transform, bool isSearchEntry)
		{
			this.transform = transform;
			this.isSearchEntry = isSearchEntry;
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xAE43B0", Offset = "0xAE2DB0", VA = "0x180AE43B0", Slot = "9")]
		public override Transform GetChild(int index)
		{
			//Discarded unreachable code: IL_000d
			return transform.GetChild(index);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xAE4540", Offset = "0xAE2F40", VA = "0x180AE4540")]
		public void ResetCachedName()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xAE4450", Offset = "0xAE2E50", VA = "0x180AE4450")]
		public void RefreshNameOf(Transform target)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xAE4400", Offset = "0xAE2E00", VA = "0x180AE4400")]
		public void PoolData()
		{
			//IL_0009: Expected O, but got I4
			//IL_0010: Expected O, but got I4
			int num = 0;
			parent = (HierarchyData)num;
			cachedName = (string)num;
			m_height = num;
			PoolChildrenList();
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0xAE4600", Offset = "0xAE3000", VA = "0x180AE4600")]
		public HierarchyDataTransform()
		{
			//IL_0009: Expected I4, but got I8
			m_height = 1;
			((object)this)._002Ector();
		}
	}
}
