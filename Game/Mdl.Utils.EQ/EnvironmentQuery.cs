using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Profiling;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Mdl.Utils.EQ
{
	[Cpp2IlInjected.Token(Token = "0x20007E7")]
	public class EnvironmentQuery
	{
		[Cpp2IlInjected.Token(Token = "0x20007E8")]
		public struct QueryPosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002C43")]
			public GameObject GameObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4002C44")]
			public Vector3 Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4002C45")]
			public bool Filtered;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002C46")]
			public float Score;
		}

		[Cpp2IlInjected.Token(Token = "0x20007E9")]
		public class QueryPositionList : IEnumerable<QueryPosition>, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x20007EA")]
			private class FilterComparer : IComparer<QueryPosition>
			{
				[Cpp2IlInjected.Token(Token = "0x600231C")]
				[Cpp2IlInjected.Address(RVA = "0x12C4690", Offset = "0x12C3090", VA = "0x1812C4690", Slot = "4")]
				public int Compare(QueryPosition x, QueryPosition y)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600231D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public FilterComparer()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20007EB")]
			private class ScoreComparer : IComparer<QueryPosition>
			{
				[Cpp2IlInjected.Token(Token = "0x600231E")]
				[Cpp2IlInjected.Address(RVA = "0x12C59F0", Offset = "0x12C43F0", VA = "0x1812C59F0", Slot = "4")]
				public int Compare(QueryPosition x, QueryPosition y)
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600231F")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public ScoreComparer()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4002C47")]
			private QueryPosition[] storage = new QueryPosition[0];

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002C48")]
			private int count;

			[Cpp2IlInjected.Token(Token = "0x4002C49")]
			private static FilterComparer filterComparer = new FilterComparer();

			[Cpp2IlInjected.Token(Token = "0x4002C4A")]
			private static ScoreComparer scoreComparer;

			[Cpp2IlInjected.Token(Token = "0x170004E0")]
			public int Count
			{
				[Cpp2IlInjected.Token(Token = "0x600230C")]
				[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
				get
				{
					return count;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170004E1")]
			public QueryPosition[] Mutable
			{
				[Cpp2IlInjected.Token(Token = "0x600230D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				get
				{
					return storage;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170004E2")]
			public QueryPosition this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x6002318")]
				[Cpp2IlInjected.Address(RVA = "0x137E990", Offset = "0x137D390", VA = "0x18137E990")]
				get
				{
					throw new NullReferenceException();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600230E")]
			[Cpp2IlInjected.Address(RVA = "0x137E770", Offset = "0x137D170", VA = "0x18137E770")]
			public void Reserve(int reserveCount)
			{
				//Discarded unreachable code: IL_002a
				QueryPosition[] array = storage;
				int num = count;
				num += reserveCount;
				if (num > array.Length)
				{
					QueryPosition[] array2 = (storage = new QueryPosition[0]);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600230F")]
			[Cpp2IlInjected.Address(RVA = "0x137E5F0", Offset = "0x137CFF0", VA = "0x18137E5F0")]
			private int GetNextIndex()
			{
				//Discarded unreachable code: IL_005f
				//IL_0024: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Expected O, but got Unknown
				int result = count;
				int num = count;
				QueryPosition[] array = storage;
				int num2 = num + 1;
				if (num2 > array.Length)
				{
					array = (QueryPosition[])(array - num2);
					QueryPosition[] destinationArray = new QueryPosition[(object)array];
					QueryPosition[] array2 = storage;
					int length = array2.Length;
					Array.Copy(array2, destinationArray, length);
					storage = destinationArray;
				}
				num = (count = num + 1);
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6002310")]
			[Cpp2IlInjected.Address(RVA = "0x137E6B0", Offset = "0x137D0B0", VA = "0x18137E6B0")]
			private int GetNextIndices(int newItemCount)
			{
				//Discarded unreachable code: IL_004a
				//IL_0048: Expected I4, but got O
				int num = count;
				QueryPosition[] array = storage;
				if (newItemCount > array.Length)
				{
					num -= newItemCount;
					QueryPosition[] destinationArray = new QueryPosition[newItemCount];
					QueryPosition[] array2 = storage;
					int length = array2.Length;
					Array.Copy(array2, destinationArray, length);
					storage = destinationArray;
				}
				count = (int)array;
				return num;
			}

			[Cpp2IlInjected.Token(Token = "0x6002311")]
			[Cpp2IlInjected.Address(RVA = "0x137E240", Offset = "0x137CC40", VA = "0x18137E240")]
			public unsafe void Add(GameObject gameObject)
			{
				//Discarded unreachable code: IL_0046
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				//IL_0018: Expected native int or pointer, but got O
				int nextIndex = GetNextIndex();
				QueryPosition[] array = storage;
				int num = nextIndex + 1;
				array = (QueryPosition[])(array + num);
				((QueryPosition*)(IntPtr)array)->GameObject = gameObject;
				QueryPosition[] array2 = storage;
				Transform transform = gameObject.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				QueryPosition[] array3 = storage;
				QueryPosition[] array4 = storage;
			}

			[Cpp2IlInjected.Token(Token = "0x6002312")]
			[Cpp2IlInjected.Address(RVA = "0x20BD7C0", Offset = "0x20BC1C0", VA = "0x1820BD7C0")]
			public void AddRange<T>(T[] array, int size, Func<T, GameObject> selector)
			{
				//Discarded unreachable code: IL_003d
				int nextIndices = GetNextIndices(size);
				if (size > 0)
				{
					storage[0] = (QueryPosition)this;
					QueryPosition[] array2 = storage;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					QueryPosition[] array3 = storage;
					QueryPosition[] array4 = storage;
					nextIndices++;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002313")]
			[Cpp2IlInjected.Address(RVA = "0x137E150", Offset = "0x137CB50", VA = "0x18137E150")]
			public void Add(Vector3 position)
			{
				//Discarded unreachable code: IL_0036
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				int nextIndex = GetNextIndex();
				QueryPosition[] array = storage;
				int num = nextIndex + 1;
				array = (QueryPosition[])(array + num);
				QueryPosition[] array2 = storage;
				float z = position.z;
				QueryPosition[] array3 = storage;
				QueryPosition[] array4 = storage;
			}

			[Cpp2IlInjected.Token(Token = "0x6002314")]
			[Cpp2IlInjected.Address(RVA = "0x137E050", Offset = "0x137CA50", VA = "0x18137E050")]
			public unsafe void Add(GameObject gameObject, Vector3 position)
			{
				//Discarded unreachable code: IL_003d
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				//IL_0018: Expected native int or pointer, but got O
				int nextIndex = GetNextIndex();
				QueryPosition[] array = storage;
				int num = nextIndex + 1;
				array = (QueryPosition[])(array + num);
				((QueryPosition*)(IntPtr)array)->GameObject = gameObject;
				QueryPosition[] array2 = storage;
				float z = position.z;
				QueryPosition[] array3 = storage;
				QueryPosition[] array4 = storage;
			}

			[Cpp2IlInjected.Token(Token = "0x6002315")]
			[Cpp2IlInjected.Address(RVA = "0x137E360", Offset = "0x137CD60", VA = "0x18137E360")]
			public unsafe void Clear()
			{
				//Discarded unreachable code: IL_002d
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001a: Expected I4, but got Unknown
				int num = 0;
				if (count > num)
				{
					QueryPosition[] array = storage;
					num++;
					num += array;
					((int*)num)->m_value = num;
					num++;
				}
				count = num;
			}

			[Cpp2IlInjected.Token(Token = "0x6002316")]
			[Cpp2IlInjected.Address(RVA = "0x137E580", Offset = "0x137CF80", VA = "0x18137E580", Slot = "4")]
			public IEnumerator<QueryPosition> GetEnumerator()
			{
				int num = count;
				IEnumerable<QueryPosition> enumerable = (IEnumerable<QueryPosition>)Enumerable.Take<QueryPosition>((IEnumerable<>)(object)storage, num);
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6002317")]
			[Cpp2IlInjected.Address(RVA = "0x137E810", Offset = "0x137D210", VA = "0x18137E810", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				int num = count;
				IEnumerable<QueryPosition> enumerable = (IEnumerable<QueryPosition>)Enumerable.Take<QueryPosition>((IEnumerable<>)(object)storage, num);
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6002319")]
			[Cpp2IlInjected.Address(RVA = "0x137E3E0", Offset = "0x137CDE0", VA = "0x18137E3E0")]
			public unsafe void FilterAndSort()
			{
				//Discarded unreachable code: IL_0051
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Expected O, but got Unknown
				//IL_003d: Expected O, but got I4
				//IL_0038: Expected native int or pointer, but got O
				QueryPosition[] array = storage;
				int num = count;
				int num2 = 0;
				if (num > 0)
				{
					QueryPosition[] array2 = storage;
					num2++;
				}
				if (num2 < num)
				{
					QueryPosition[] array3 = storage;
					num2++;
					array3 = (QueryPosition[])(array3 + num2);
					((QueryPosition*)(IntPtr)array3)->GameObject = (GameObject)num2;
					num2++;
				}
				QueryPosition[] array4 = storage;
				count = num2;
			}

			[Cpp2IlInjected.Token(Token = "0x600231A")]
			[Cpp2IlInjected.Address(RVA = "0x137E930", Offset = "0x137D330", VA = "0x18137E930")]
			public QueryPositionList()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600231B")]
			[Cpp2IlInjected.Address(RVA = "0x137E880", Offset = "0x137D280", VA = "0x18137E880")]
			static QueryPositionList()
			{
				filterComparer = (FilterComparer)(object)new ScoreComparer();
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20007EC")]
		public struct Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4002C4B")]
			public GameObject GameObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4002C4C")]
			public Vector3 Position;
		}

		[Cpp2IlInjected.Token(Token = "0x20007ED")]
		public abstract class Generator
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002C4F")]
			public bool OnNavMesh = true;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4002C50")]
			public int AreaMask = -1;

			[Cpp2IlInjected.Token(Token = "0x4002C51")]
			protected static readonly GameObject[] NoGameObjects = new GameObject[0];

			[Cpp2IlInjected.Token(Token = "0x4002C52")]
			protected static readonly Vector3[] NoPositions;

			[Cpp2IlInjected.Token(Token = "0x170004E3")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002C4D")]
			protected bool IsDebugging
			{
				[Cpp2IlInjected.Token(Token = "0x6002320")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6002321")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x170004E4")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4002C4E")]
			protected float DebugDuration
			{
				[Cpp2IlInjected.Token(Token = "0x6002322")]
				[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6002323")]
				[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610")]
				private set;
			} = 0.1f;


			[Cpp2IlInjected.Token(Token = "0x6002324")]
			[Cpp2IlInjected.Address(RVA = "0x137D920", Offset = "0x137C320", VA = "0x18137D920")]
			[Conditional("DEBUG")]
			public void EnableDebugging(float duration = 0.1f)
			{
				DebugDuration = duration;
				IsDebugging = true;
			}

			[Cpp2IlInjected.Token(Token = "0x6002325")]
			[Cpp2IlInjected.Address(RVA = "0x137D930", Offset = "0x137C330", VA = "0x18137D930")]
			public int RunGenerate(QueryPositionList positionList, GameObject queryObject, Vector3 queryPosition)
			{
				//Discarded unreachable code: IL_0040
				float z = queryPosition.z;
				int num = default(int);
				if (OnNavMesh && num > 0)
				{
					int count = positionList.count;
					count -= num;
					if (count < count)
					{
						QueryPosition[] storage = positionList.storage;
						int num2 = 0;
						int num3 = 0;
						bool flag = default(bool);
						if (AreaMask != (flag ? 1 : 0))
						{
						}
						count++;
					}
				}
				return num;
			}

			[Cpp2IlInjected.Token(Token = "0x6002326")]
			[Cpp2IlInjected.Address(Slot = "4")]
			protected abstract int Generate(QueryPositionList positionList, GameObject queryObject, Vector3 queryPosition);

			[Cpp2IlInjected.Token(Token = "0x6002327")]
			[Cpp2IlInjected.Address(RVA = "0x137DB10", Offset = "0x137C510", VA = "0x18137DB10")]
			private Vector3 SnapPositionToNavMesh(Vector3 position)
			{
				int num = 0;
				int num2 = 0;
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6002328")]
			[Cpp2IlInjected.Address(RVA = "0x137DC70", Offset = "0x137C670", VA = "0x18137DC70")]
			protected Generator()
			{
			}//IL_0022: Expected I4, but got I8


			[Cpp2IlInjected.Token(Token = "0x6002329")]
			[Cpp2IlInjected.Address(RVA = "0x137DBE0", Offset = "0x137C5E0", VA = "0x18137DBE0")]
			static Generator()
			{
				NoGameObjects = (GameObject[])(object)new Vector3[0];
				/*Error: Unexpected end of block*/;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20007EE")]
		public abstract class Test
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4002C55")]
			public bool InvertScore;

			[Cpp2IlInjected.Token(Token = "0x170004E5")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4002C53")]
			protected bool IsDebugging
			{
				[Cpp2IlInjected.Token(Token = "0x600232A")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600232B")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				private set;
			}

			[Cpp2IlInjected.Token(Token = "0x170004E6")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4002C54")]
			protected float DebugDuration
			{
				[Cpp2IlInjected.Token(Token = "0x600232C")]
				[Cpp2IlInjected.Address(RVA = "0x7F3600", Offset = "0x7F2000", VA = "0x1807F3600")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600232D")]
				[Cpp2IlInjected.Address(RVA = "0x7F3610", Offset = "0x7F2010", VA = "0x1807F3610")]
				private set;
			} = 0.1f;


			[Cpp2IlInjected.Token(Token = "0x170004E7")]
			public virtual float Cost
			{
				[Cpp2IlInjected.Token(Token = "0x600232F")]
				[Cpp2IlInjected.Address(RVA = "0xD247B0", Offset = "0xD231B0", VA = "0x180D247B0", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600232E")]
			[Cpp2IlInjected.Address(RVA = "0x137D920", Offset = "0x137C320", VA = "0x18137D920")]
			[Conditional("DEBUG")]
			public void EnableDebugging(float duration = 0.1f)
			{
				DebugDuration = duration;
				IsDebugging = true;
			}

			[Cpp2IlInjected.Token(Token = "0x6002330")]
			[Cpp2IlInjected.Address(RVA = "0x137F3C0", Offset = "0x137DDC0", VA = "0x18137F3C0")]
			public (bool, float) RunFilterAndScore(GameObject queryObject, Vector3 queryPosition, GameObject gameObject, Vector3 position)
			{
				while (true)
				{
					float z = queryPosition.z;
					if (InvertScore)
					{
						/*Error: Could not find block for branch target IL_0010*/;
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002331")]
			[Cpp2IlInjected.Address(RVA = "0x137F320", Offset = "0x137DD20", VA = "0x18137F320", Slot = "5")]
			protected virtual (bool, float) FilterAndScore(GameObject queryObject, Vector3 queryPosition, GameObject gameObject, Vector3 position)
			{
				float z = queryPosition.z;
				(bool, float) result = default((bool, float));
				return result;
			}

			[Cpp2IlInjected.Token(Token = "0x6002332")]
			[Cpp2IlInjected.Address(RVA = "0x137F380", Offset = "0x137DD80", VA = "0x18137F380", Slot = "6")]
			protected virtual (bool, float) FilterAndScore(GameObject queryObject, Vector3 queryPosition, Vector3 position)
			{
				NotImplementedException ex = new NotImplementedException();
				/*Error: Unexpected end of block*/;
			}

			[Cpp2IlInjected.Token(Token = "0x6002333")]
			[Cpp2IlInjected.Address(RVA = "0x137F4C0", Offset = "0x137DEC0", VA = "0x18137F4C0")]
			protected Test()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20007EF")]
		public class LambdaTest : Test
		{
			[Cpp2IlInjected.Token(Token = "0x20007F0")]
			public delegate(bool, float) LambdaGameObjectTest(GameObject queryObject, Vector3 queryPosition, GameObject gameObject);

			[Cpp2IlInjected.Token(Token = "0x20007F1")]
			public delegate(bool, float) LambdaPosition(GameObject queryObject, Vector3 queryPosition, Vector3 position);

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4002C56")]
			protected LambdaGameObjectTest testGameObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4002C57")]
			protected LambdaPosition testPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4002C58")]
			protected float cost = 1f;

			[Cpp2IlInjected.Token(Token = "0x170004E8")]
			public override float Cost
			{
				[Cpp2IlInjected.Token(Token = "0x6002334")]
				[Cpp2IlInjected.Address(RVA = "0x83A7F0", Offset = "0x8391F0", VA = "0x18083A7F0", Slot = "4")]
				get
				{
					return cost;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002335")]
			[Cpp2IlInjected.Address(RVA = "0x137DDC0", Offset = "0x137C7C0", VA = "0x18137DDC0")]
			public LambdaTest(LambdaGameObjectTest test, float cost = 1f)
			{
				base.DebugDuration = 0.1f;
				((object)this)._002Ector();
				testGameObject = test;
				this.cost = cost;
			}

			[Cpp2IlInjected.Token(Token = "0x6002336")]
			[Cpp2IlInjected.Address(RVA = "0x137DD60", Offset = "0x137C760", VA = "0x18137DD60")]
			public LambdaTest(LambdaPosition test, float cost = 1f)
			{
				base.DebugDuration = 0.1f;
				((object)this)._002Ector();
				testPosition = test;
				this.cost = cost;
			}

			[Cpp2IlInjected.Token(Token = "0x6002337")]
			[Cpp2IlInjected.Address(RVA = "0x137DC90", Offset = "0x137C690", VA = "0x18137DC90", Slot = "5")]
			protected override (bool, float) FilterAndScore(GameObject queryObject, Vector3 queryPosition, GameObject gameObject, Vector3 position)
			{
				if (testGameObject == null)
				{
					if (testPosition != null)
					{
						float z = queryPosition.z;
						(bool, float) result = default((bool, float));
						return result;
					}
					InvalidOperationException ex = new InvalidOperationException();
					/*Error: Unexpected end of block*/;
				}
				float z2 = queryPosition.z;
				(bool, float) result2 = default((bool, float));
				return result2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20007F2")]
		public abstract class TestComponent<T> : Test where T : Component
		{
			[Cpp2IlInjected.Token(Token = "0x4002C59")]
			private static readonly ProfilerMarker s_Profiler_TestComponent;

			[Cpp2IlInjected.Token(Token = "0x4002C5A")]
			private static readonly ProfilerMarker s_Profiler_GetComponent;

			[Cpp2IlInjected.Token(Token = "0x4002C5B")]
			private static readonly ProfilerMarker s_Profiler_Test;

			[Cpp2IlInjected.Token(Token = "0x170004E9")]
			public override float Cost
			{
				[Cpp2IlInjected.Token(Token = "0x6002340")]
				[Cpp2IlInjected.Address(RVA = "0xF3BDA0", Offset = "0xF3A7A0", VA = "0x180F3BDA0", Slot = "4")]
				get
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6002341")]
			[Cpp2IlInjected.Address(RVA = "0x2C86A40", Offset = "0x2C85440", VA = "0x182C86A40", Slot = "5")]
			protected override (bool, float) FilterAndScore(GameObject queryObject, Vector3 queryPosition, GameObject gameObject, Vector3 position)
			{
				int num = 0;
				bool flag = default(bool);
				if (!flag)
				{
					float z = queryPosition.z;
					(bool, float) result = default((bool, float));
					return result;
				}
				int num2 = 0;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6002342")]
			[Cpp2IlInjected.Address(Slot = "7")]
			protected abstract (bool, float) FilterAndScoreComponent(GameObject queryObject, Vector3 queryPosition, GameObject gameObject, T component, Vector3 position);

			[Cpp2IlInjected.Token(Token = "0x6002343")]
			[Cpp2IlInjected.Address(RVA = "0x2C86E20", Offset = "0x2C85820", VA = "0x182C86E20")]
			protected TestComponent()
			{
			}//Discarded unreachable code: IL_0007


			[Cpp2IlInjected.Token(Token = "0x6002344")]
			[Cpp2IlInjected.Address(RVA = "0x2C86BA0", Offset = "0x2C855A0", VA = "0x182C86BA0")]
			static TestComponent()
			{
				//Discarded unreachable code: IL_0076
				int num = 0;
				int flags = 0;
				int metadataCount = 0;
				ushort categoryId = default(ushort);
				IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("FilterAndScore.TestComponent", categoryId, (MarkerFlags)flags, metadataCount);
				int num2 = 0;
				Type type = default(Type);
				string name = type.Name;
				string name2 = "FilterAndScore.GetComponent." + name;
				int flags2 = 0;
				int metadataCount2 = 0;
				ushort categoryId2 = default(ushort);
				IntPtr intPtr2 = ProfilerUnsafeUtility.CreateMarker(name2, categoryId2, (MarkerFlags)flags2, metadataCount2);
				int num3 = 0;
				Type type2 = default(Type);
				string name3 = type2.Name;
				string name4 = "FilterAndScore.Test." + name3;
				int flags3 = 0;
				int metadataCount3 = 0;
				ushort categoryId3 = default(ushort);
				IntPtr intPtr3 = ProfilerUnsafeUtility.CreateMarker(name4, categoryId3, (MarkerFlags)flags3, metadataCount3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002C36")]
		private static readonly ProfilerMarker s_EnvironmentQuery;

		[Cpp2IlInjected.Token(Token = "0x4002C37")]
		private static readonly ProfilerMarker s_EnvironmentQuery_Generate;

		[Cpp2IlInjected.Token(Token = "0x4002C38")]
		private static readonly ProfilerMarker s_EnvironmentQuery_FilterAndScore;

		[Cpp2IlInjected.Token(Token = "0x4002C39")]
		private static readonly ProfilerMarker s_EnvironmentQuery_Test;

		[Cpp2IlInjected.Token(Token = "0x4002C3A")]
		private static readonly ProfilerMarker s_EnvironmentQuery_TestLambda;

		[Cpp2IlInjected.Token(Token = "0x4002C3B")]
		private static readonly ProfilerMarker s_EnvironmentQuery_Realloc;

		[Cpp2IlInjected.Token(Token = "0x4002C3C")]
		private static readonly ProfilerMarker s_EnvironmentQuery_SnapToMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002C3D")]
		private List<Generator> generators = (List<Generator>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002C3E")]
		private List<Tuple<float, Test>> tests = (List<Tuple<float, Test>>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002C3F")]
		private float debugDuration = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002C40")]
		private bool enableDebugging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002C41")]
		private QueryPositionList qpl = new QueryPositionList();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002C42")]
		private Result[] results = new Result[0];

		[Cpp2IlInjected.Token(Token = "0x6002300")]
		[Cpp2IlInjected.Address(RVA = "0x1362400", Offset = "0x1360E00", VA = "0x181362400")]
		public void AddGenerator(Generator generator)
		{
			//Discarded unreachable code: IL_000d
			((List<T>)(object)generators).Add((T)generator);
		}

		[Cpp2IlInjected.Token(Token = "0x6002301")]
		[Cpp2IlInjected.Address(RVA = "0x13624E0", Offset = "0x1360EE0", VA = "0x1813624E0")]
		public void AddTest(float weight, Test test)
		{
			//Discarded unreachable code: IL_003a
			Tuple<float, Test> item = default(Tuple<float, Test>);
			((List<T>)(object)tests).Add((T)item);
			List<Tuple<float, Test>> list = tests;
			Comparison<Tuple<float, Test>> _003C_003E9__12_ = _003C_003Ec._003C_003E9__12_0;
			if (_003C_003E9__12_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Comparison<T>)delegate
				{
					throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				};
			}
			((List<T>)(object)list).Sort((Comparison<>)(object)_003C_003E9__12_);
		}

		[Cpp2IlInjected.Token(Token = "0x6002302")]
		[Cpp2IlInjected.Address(RVA = "0x13622E0", Offset = "0x1360CE0", VA = "0x1813622E0")]
		public void AddFilter(Test filter)
		{
			//Discarded unreachable code: IL_000d
			Tuple<float, Test> item = default(Tuple<float, Test>);
			((List<T>)(object)tests).Add((T)item);
		}

		[Cpp2IlInjected.Token(Token = "0x6002303")]
		[Cpp2IlInjected.Address(RVA = "0x1362380", Offset = "0x1360D80", VA = "0x181362380")]
		public void AddGameObjectFilter(LambdaTest.LambdaGameObjectTest test)
		{
			LambdaTest filter = new LambdaTest(test);
			AddFilter(filter);
		}

		[Cpp2IlInjected.Token(Token = "0x6002304")]
		[Cpp2IlInjected.Address(RVA = "0x1362460", Offset = "0x1360E60", VA = "0x181362460")]
		public void AddPositionFilter(LambdaTest.LambdaPosition test)
		{
			LambdaTest filter = new LambdaTest(test);
			AddFilter(filter);
		}

		[Cpp2IlInjected.Token(Token = "0x6002305")]
		[Cpp2IlInjected.Address(RVA = "0x1362E70", Offset = "0x1361870", VA = "0x181362E70")]
		[Conditional("DEBUG")]
		public void EnableDebugging(float duration = 0.1f)
		{
			debugDuration = duration;
			enableDebugging = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6002306")]
		[Cpp2IlInjected.Address(RVA = "0x1255860", Offset = "0x1254260", VA = "0x181255860")]
		[Conditional("DEBUG")]
		public void DebugAdjustTestWeight<TestType>(float newWeight)
		{
			//Discarded unreachable code: IL_003b, IL_0041
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected I4, but got Unknown
			List<Tuple<float, Test>> list = tests;
			bool flag = default(bool);
			if (flag)
			{
				while (!flag)
				{
				}
				List<Tuple<float, Test>> list2 = tests;
			}
			int num = 0;
			num += num;
			num++;
			num += 312;
			num += typeof(List<Tuple<float, Test>>.Enumerator).TypeHandle;
		}

		[Cpp2IlInjected.Token(Token = "0x6002307")]
		[Cpp2IlInjected.Address(RVA = "0x1362F90", Offset = "0x1361990", VA = "0x181362F90")]
		public IEnumerable<Result> Run(GameObject querier, [System.Runtime.InteropServices.Optional] Vector3? position)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002308")]
		[Cpp2IlInjected.Address(RVA = "0x1362E80", Offset = "0x1361880", VA = "0x181362E80")]
		public Result? RunSingle(GameObject querier, [System.Runtime.InteropServices.Optional] Vector3? position)
		{
			//IL_0012: Expected O, but got I4
			//IL_001b: Expected O, but got I4
			IEnumerable<Result> enumerable = default(IEnumerable<Result>);
			if (!Enumerable.Any<Result>((IEnumerable<>)enumerable))
			{
				int num = 0;
				generators = (List<Generator>)num;
			}
			int num2 = 0;
			generators = (List<Generator>)num2;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6002309")]
		[Cpp2IlInjected.Address(RVA = "0x1362690", Offset = "0x1361090", VA = "0x181362690")]
		[Conditional("DEBUG")]
		private void DebugGeneratedPositions(IEnumerable<QueryPosition> queryPositions)
		{
			//Discarded unreachable code: IL_0127
			//IL_0113: Invalid comparison between F4 and I4
			int num = 0;
			int num2 = 0;
			Func<QueryPosition, float> _003C_003E9__25_ = _003C_003Ec._003C_003E9__25_0;
			if (_003C_003E9__25_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((QueryPosition qp) => qp.Score);
			}
			IOrderedEnumerable<QueryPosition> orderedEnumerable = (IOrderedEnumerable<QueryPosition>)Enumerable.OrderBy<QueryPosition, float>((IEnumerable<>)queryPositions, (Func<, >)(object)_003C_003E9__25_);
			Func<QueryPosition, bool> func = default(Func<QueryPosition, bool>);
			if (_003C_003Ec._003C_003E9__25_1 == null)
			{
				func = (Func<QueryPosition, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((QueryPosition x) => x.Position.z == 0f));
			}
			IEnumerable<QueryPosition> enumerable = (IEnumerable<QueryPosition>)Enumerable.Where<QueryPosition>((IEnumerable<>)orderedEnumerable, (Func<, >)(object)func);
			Func<QueryPosition, float> func2 = default(Func<QueryPosition, float>);
			if (_003C_003Ec._003C_003E9__25_2 == null)
			{
				func2 = (Func<QueryPosition, float>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((QueryPosition x) => x.Score));
			}
			float num3 = Enumerable.FirstOrDefault<float>(Enumerable.Select<QueryPosition, float>((IEnumerable<>)enumerable, (Func<, >)(object)func2));
			Func<QueryPosition, bool> func3 = default(Func<QueryPosition, bool>);
			if (_003C_003Ec._003C_003E9__25_3 == null)
			{
				func3 = (Func<QueryPosition, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((QueryPosition x) => x.Position.z == 0f));
			}
			IEnumerable<QueryPosition> enumerable2 = (IEnumerable<QueryPosition>)Enumerable.Where<QueryPosition>((IEnumerable<>)orderedEnumerable, (Func<, >)(object)func3);
			Func<QueryPosition, float> func4 = default(Func<QueryPosition, float>);
			if (_003C_003Ec._003C_003E9__25_4 == null)
			{
				func4 = (Func<QueryPosition, float>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((QueryPosition x) => x.Score));
			}
			IEnumerable<QueryPosition> enumerable3 = (IEnumerable<QueryPosition>)Enumerable.Select<QueryPosition, float>((IEnumerable<>)enumerable2, (Func<, >)(object)func4);
			float num4 = Enumerable.LastOrDefault<float>((IEnumerable<>)enumerable3);
			int num5 = 0;
			if (enumerable3 != null)
			{
				uint num6 = default(uint);
				if (num2 < (int)num6)
				{
					num2 += num2;
					if (num2 == (int)num6)
					{
						goto IL_0121;
					}
					num2++;
				}
				Color black = Color.black;
				Color green = Color.green;
				if (!(num4 <= (float)num5))
				{
				}
				float z = Vector3.up.z;
			}
			goto IL_0121;
			IL_0121:
			if (enumerable3 == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600230A")]
		[Cpp2IlInjected.Address(RVA = "0x13638A0", Offset = "0x13622A0", VA = "0x1813638A0")]
		public EnvironmentQuery()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600230B")]
		[Cpp2IlInjected.Address(RVA = "0x1363650", Offset = "0x1362050", VA = "0x181363650")]
		static EnvironmentQuery()
		{
			//IL_0025: Expected O, but got I
			//IL_0047: Expected O, but got I
			//IL_0069: Expected O, but got I
			//IL_008b: Expected O, but got I
			//IL_00ad: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00ea: Expected O, but got I
			int num = 0;
			int num2 = 0;
			int flags = 0;
			int metadataCount = 0;
			ushort categoryId = default(ushort);
			IntPtr intPtr = ProfilerUnsafeUtility.CreateMarker("EnvironmentQuery", categoryId, (MarkerFlags)flags, metadataCount);
			int num3 = 0;
			s_EnvironmentQuery = (ProfilerMarker)(long)intPtr;
			int flags2 = 0;
			int metadataCount2 = 0;
			ushort categoryId2 = default(ushort);
			IntPtr intPtr2 = ProfilerUnsafeUtility.CreateMarker("Generate", categoryId2, (MarkerFlags)flags2, metadataCount2);
			int num4 = 0;
			s_EnvironmentQuery_Generate = (ProfilerMarker)(long)intPtr2;
			int flags3 = 0;
			int metadataCount3 = 0;
			ushort categoryId3 = default(ushort);
			IntPtr intPtr3 = ProfilerUnsafeUtility.CreateMarker("FilterAndScore", categoryId3, (MarkerFlags)flags3, metadataCount3);
			int num5 = 0;
			s_EnvironmentQuery_FilterAndScore = (ProfilerMarker)(long)intPtr3;
			int flags4 = 0;
			int metadataCount4 = 0;
			ushort categoryId4 = default(ushort);
			IntPtr intPtr4 = ProfilerUnsafeUtility.CreateMarker("Test", categoryId4, (MarkerFlags)flags4, metadataCount4);
			int num6 = 0;
			s_EnvironmentQuery_Test = (ProfilerMarker)(long)intPtr4;
			int flags5 = 0;
			int metadataCount5 = 0;
			ushort categoryId5 = default(ushort);
			IntPtr intPtr5 = ProfilerUnsafeUtility.CreateMarker("Test.Lambda", categoryId5, (MarkerFlags)flags5, metadataCount5);
			int num7 = 0;
			s_EnvironmentQuery_TestLambda = (ProfilerMarker)(long)intPtr5;
			int flags6 = 0;
			int metadataCount6 = 0;
			ushort categoryId6 = default(ushort);
			IntPtr intPtr6 = ProfilerUnsafeUtility.CreateMarker("Realloc", categoryId6, (MarkerFlags)flags6, metadataCount6);
			int num8 = 0;
			s_EnvironmentQuery_Realloc = (ProfilerMarker)(long)intPtr6;
			int flags7 = 0;
			int metadataCount7 = 0;
			ushort categoryId7 = default(ushort);
			s_EnvironmentQuery_SnapToMesh = (ProfilerMarker)(long)ProfilerUnsafeUtility.CreateMarker("SnapToMesh", categoryId7, (MarkerFlags)flags7, metadataCount7);
		}
	}
}
