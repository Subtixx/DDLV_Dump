using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Mdl.Avatar;
using Mdl.Utils;
using UnityEngine;

namespace Mdl.Display
{
	[Cpp2IlInjected.Token(Token = "0x200081B")]
	public abstract class BaseMannequin : ItemSupport
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002D47")]
		public Transform RootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002D48")]
		public SkinnedMeshRenderer combinedMannequin;

		[Cpp2IlInjected.Token(Token = "0x1700052A")]
		public Dictionary<string, Transform> SkeletonDefinition
		{
			[Cpp2IlInjected.Token(Token = "0x6002458")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			[CompilerGenerated]
			get
			{
				return _003CSkeletonDefinition_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6002459")]
			[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
			[CompilerGenerated]
			private set
			{
				_003CSkeletonDefinition_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = (Dictionary<string, Transform>)(object)new Dictionary<TKey, TValue>();


		[Cpp2IlInjected.Token(Token = "0x600245A")]
		[Cpp2IlInjected.Address(RVA = "0x163B480", Offset = "0x1639E80", VA = "0x18163B480", Slot = "8")]
		protected virtual void Awake()
		{
			//Discarded unreachable code: IL_004a, IL_004f
			//IL_0010: Expected O, but got I4
			Transform rootBone = RootBone;
			int num = 0;
			if (rootBone != (UnityEngine.Object)num)
			{
				Transform[] componentsInChildren = RootBone.GetComponentsInChildren<Transform>();
				int num2 = 0;
				int length = componentsInChildren.Length;
				if (num2 < length)
				{
					Dictionary<string, Transform> dictionary = SkeletonDefinition;
					string text = componentsInChildren[num2].name;
					throw new NullReferenceException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600245B")]
		[Cpp2IlInjected.Address(RVA = "0x163B780", Offset = "0x163A180", VA = "0x18163B780")]
		protected void UpdateBodyTypeBlendShape(SkinnedMeshRenderer smr)
		{
			//Discarded unreachable code: IL_0044
			//IL_0032: Expected O, but got I4
			//IL_0043: Expected F4, but got I4
			IAvatarInfoProvider avatarInfoProvider = base.avatarInfoProvider;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if ((object)typeof(IAvatarInfoProvider).TypeHandle != null)
			{
				int num3 = 0;
				Mesh sharedMesh = smr.sharedMesh;
				int num4 = 0;
				int blendShapeIndex = sharedMesh.GetBlendShapeIndex((string)num3);
				if (blendShapeIndex != -1)
				{
					smr.SetBlendShapeWeight(blendShapeIndex, num4);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600245C")]
		[Cpp2IlInjected.Address(RVA = "0x163B880", Offset = "0x163A280", VA = "0x18163B880")]
		protected void UpdateConditionalBlendShapes(SkinnedMeshRenderer smr, ClothingItemScript clothingScript)
		{
			//Discarded unreachable code: IL_0051
			int num = 0;
			int blendShapeCount = smr.sharedMesh.blendShapeCount;
			if (num < blendShapeCount)
			{
				string name = smr.sharedMesh.GetBlendShapeName(num);
				Func<ConditionalBlendShape, bool> func = (Func<ConditionalBlendShape, bool>)(object)(Func<T, TResult>)delegate(ConditionalBlendShape x)
				{
					//Discarded unreachable code: IL_0014
					string b = name;
					return string.Equals(x.blendShapeName, b);
				};
				IEnumerable<ConditionalBlendShape> enumerable = default(IEnumerable<ConditionalBlendShape>);
				if (Enumerable.FirstOrDefault<ConditionalBlendShape>((IEnumerable<>)enumerable) != null)
				{
					IAvatarInfoProvider avatarInfoProvider = base.avatarInfoProvider;
				}
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600245D")]
		[Cpp2IlInjected.Address(RVA = "0x163B5B0", Offset = "0x1639FB0", VA = "0x18163B5B0")]
		protected bool ConditionsAreTrue(bool IsMale, ConditionalBlendShape blendShape, ClothingItemScript clothingScript)
		{
			//Discarded unreachable code: IL_0041, IL_0047
			int num = 0;
			if (IsMale)
			{
			}
			if ((blendShape.avatarIsFemale ? 1 : 0) != num && blendShape.clothingType == clothingScript.clothingType)
			{
				List<BlendShapeCondition> conditions = blendShape.conditions;
				bool flag = default(bool);
				if (flag)
				{
					List<int> options = clothingScript.options;
					int num2 = 0;
				}
				ulong num3 = default(ulong);
				return num3 == 0;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600245E")]
		[Cpp2IlInjected.Address(RVA = "0x163BAA0", Offset = "0x163A4A0", VA = "0x18163BAA0")]
		protected BaseMannequin()
		{
		}
	}
}
