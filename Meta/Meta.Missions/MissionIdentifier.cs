using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Meta.Missions
{
	[Cpp2IlInjected.Token(Token = "0x200105C")]
	public static class MissionIdentifier
	{
		[Cpp2IlInjected.Token(Token = "0x60084B4")]
		[Cpp2IlInjected.Address(RVA = "0x8000F0", Offset = "0x7FEAF0", VA = "0x1808000F0")]
		public static string GetFullIdentifierID(IMissionIdentifier value)
		{
			//Discarded unreachable code: IL_0049
			_003CEnumerateSelfAndParents_003Ed__2 _003CEnumerateSelfAndParents_003Ed__ = new _003CEnumerateSelfAndParents_003Ed__2(-2);
			_003CEnumerateSelfAndParents_003Ed__._003C_003E3__value = value;
			IEnumerable<IMissionIdentifier> enumerable = (IEnumerable<IMissionIdentifier>)Enumerable.Reverse<IMissionIdentifier>((IEnumerable<>)(object)_003CEnumerateSelfAndParents_003Ed__);
			Func<IMissionIdentifier, int> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			if (_003C_003E9__0_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				};
			}
			IEnumerable<IMissionIdentifier> enumerable2 = (IEnumerable<IMissionIdentifier>)Enumerable.Select<IMissionIdentifier, int>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__0_);
			return string.Join<int>("!", (IEnumerable<>)enumerable2);
		}

		[Cpp2IlInjected.Token(Token = "0x60084B5")]
		[Cpp2IlInjected.Address(RVA = "0x8002D0", Offset = "0x7FECD0", VA = "0x1808002D0")]
		public static string GetFullIdentifierName(IMissionIdentifier value)
		{
			//Discarded unreachable code: IL_0049
			_003CEnumerateSelfAndParents_003Ed__2 _003CEnumerateSelfAndParents_003Ed__ = new _003CEnumerateSelfAndParents_003Ed__2(-2);
			_003CEnumerateSelfAndParents_003Ed__._003C_003E3__value = value;
			IEnumerable<IMissionIdentifier> enumerable = (IEnumerable<IMissionIdentifier>)Enumerable.Reverse<IMissionIdentifier>((IEnumerable<>)(object)_003CEnumerateSelfAndParents_003Ed__);
			Func<IMissionIdentifier, string> _003C_003E9__1_ = _003C_003Ec._003C_003E9__1_0;
			if (_003C_003E9__1_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
				{
					throw new NullReferenceException();
				};
			}
			IEnumerable<IMissionIdentifier> enumerable2 = (IEnumerable<IMissionIdentifier>)Enumerable.Select<IMissionIdentifier, string>((IEnumerable<>)enumerable, (Func<, >)(object)_003C_003E9__1_);
			return string.Join("!", (IEnumerable<>)enumerable2);
		}

		[Cpp2IlInjected.Token(Token = "0x60084B6")]
		[Cpp2IlInjected.Address(RVA = "0x800080", Offset = "0x7FEA80", VA = "0x180800080")]
		[IteratorStateMachine(typeof(_003CEnumerateSelfAndParents_003Ed__2))]
		public static IEnumerable<IMissionIdentifier> EnumerateSelfAndParents(IMissionIdentifier value)
		{
			new _003CEnumerateSelfAndParents_003Ed__2(-2)._003C_003E3__value = value;
			throw new NullReferenceException();
		}
	}
}
