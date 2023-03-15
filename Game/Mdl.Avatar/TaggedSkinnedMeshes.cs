using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A78")]
	public class TaggedSkinnedMeshes : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000A79")]
		public class TaggedSmr
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40039C8")]
			public string tag;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40039C9")]
			public SkinnedMeshRenderer smr;

			[Cpp2IlInjected.Token(Token = "0x60030AC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public TaggedSmr()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40039C7")]
		public List<TaggedSmr> taggedSkinnedMeshes = (List<TaggedSmr>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x60030AA")]
		[Cpp2IlInjected.Address(RVA = "0x106D780", Offset = "0x106C180", VA = "0x18106D780")]
		public SkinnedMeshRenderer GetSmr(string tag)
		{
			//Discarded unreachable code: IL_0034
			List<TaggedSmr> list = taggedSkinnedMeshes;
			Predicate<TaggedSmr> predicate = (Predicate<TaggedSmr>)(object)(Predicate<T>)delegate(TaggedSmr t)
			{
				//Discarded unreachable code: IL_0014
				string b = tag;
				return string.Equals(t.tag, b);
			};
			TaggedSmr taggedSmr = (TaggedSmr)((List<T>)(object)list).Find((Predicate<>)(object)predicate);
			if (taggedSmr == null)
			{
			}
			return taggedSmr.smr;
		}

		[Cpp2IlInjected.Token(Token = "0x60030AB")]
		[Cpp2IlInjected.Address(RVA = "0x106D880", Offset = "0x106C280", VA = "0x18106D880")]
		public TaggedSkinnedMeshes()
		{
		}
	}
}
