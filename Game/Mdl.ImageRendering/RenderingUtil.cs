using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Avatar;
using Mdl.Furnitures;
using Meta.Customization;
using UnityEngine;

namespace Mdl.ImageRendering
{
	[Cpp2IlInjected.Token(Token = "0x20003EC")]
	public static class RenderingUtil
	{
		[Cpp2IlInjected.Token(Token = "0x60010D1")]
		[Cpp2IlInjected.Address(RVA = "0xCC0C60", Offset = "0xCBF660", VA = "0x180CC0C60")]
		public static Bounds GetBounds(Renderer[] renderers)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60010D2")]
		[Cpp2IlInjected.Address(RVA = "0xCC10B0", Offset = "0xCBFAB0", VA = "0x180CC10B0")]
		public static Bounds GetBounds(List<Bounds> bounds)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			System.ThrowHelper.ThrowArgumentOutOfRangeException();
			bool flag = default(bool);
			if (flag)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010D3")]
		[Cpp2IlInjected.Address(RVA = "0xCC0BC0", Offset = "0xCBF5C0", VA = "0x180CC0BC0")]
		public unsafe static Bounds GetBounds(Bounds bounds)
		{
			//IL_0009: Expected O, but got I4
			//IL_0004: Expected native int or pointer, but got O
			//IL_0017: Expected F4, but got I4
			//IL_0012: Expected native int or pointer, but got O
			int num = 0;
			((Bounds*)(IntPtr)bounds)->m_Center = (UnityEngine.Vector3)num;
			int num2 = 0;
			((UnityEngine.Vector3*)(IntPtr)bounds.m_Extents)->y = num2;
			float z = UnityEngine.Vector3.zero.z;
			return bounds;
		}

		[Cpp2IlInjected.Token(Token = "0x60010D4")]
		[Cpp2IlInjected.Address(RVA = "0xCC12E0", Offset = "0xCBFCE0", VA = "0x180CC12E0")]
		[IteratorStateMachine(typeof(_003CRenderItem_003Ed__3))]
		public static IEnumerator RenderItem(float fill, IItemData item, Transform assetAnchor, List<UnityEngine.Vector3> anchorRefRotation, bool recenter, Camera camera, List<Material[]> materialInstances, AvatarAppearance avatar, bool isMale, FurnitureAppearance furniture, Design design)
		{
			//IL_0033: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			int _003C_003E1__state = default(int);
			_003CRenderItem_003Ed__3 _003CRenderItem_003Ed__ = new _003CRenderItem_003Ed__3(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRenderItem_003Ed__.item = item;
			_003CRenderItem_003Ed__.fill = fill;
			_003CRenderItem_003Ed__.assetAnchor = assetAnchor;
			_003CRenderItem_003Ed__.anchorRefRotation = anchorRefRotation;
			_003CRenderItem_003Ed__.recenter = false;
			_003CRenderItem_003Ed__.camera = (Camera)0;
			_003CRenderItem_003Ed__.materialInstances = (List<Material[]>)0;
			_003CRenderItem_003Ed__.avatar = (AvatarAppearance)0;
			_003CRenderItem_003Ed__.isMale = false;
			_003CRenderItem_003Ed__.furniture = (FurnitureAppearance)0;
			_003CRenderItem_003Ed__.design = (Design)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60010D5")]
		[Cpp2IlInjected.Address(RVA = "0xCC1410", Offset = "0xCBFE10", VA = "0x180CC1410")]
		[IteratorStateMachine(typeof(_003CRenderLitItem_003Ed__4))]
		public static IEnumerator RenderLitItem(float fill, IItemData item, Transform assetAnchor, List<UnityEngine.Vector3> anchorRefRotation, bool recenter, Camera camera, List<Material[]> materialInstances, AvatarAppearance avatar, bool isMale, FurnitureAppearance furniture, Design design)
		{
			//IL_0033: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_004f: Expected O, but got I4
			//IL_0056: Expected O, but got I4
			int _003C_003E1__state = default(int);
			_003CRenderLitItem_003Ed__4 _003CRenderLitItem_003Ed__ = new _003CRenderLitItem_003Ed__4(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CRenderLitItem_003Ed__.item = item;
			_003CRenderLitItem_003Ed__.fill = fill;
			_003CRenderLitItem_003Ed__.assetAnchor = assetAnchor;
			_003CRenderLitItem_003Ed__.anchorRefRotation = anchorRefRotation;
			_003CRenderLitItem_003Ed__.recenter = false;
			_003CRenderLitItem_003Ed__.camera = (Camera)0;
			_003CRenderLitItem_003Ed__.materialInstances = (List<Material[]>)0;
			_003CRenderLitItem_003Ed__.avatar = (AvatarAppearance)0;
			_003CRenderLitItem_003Ed__.isMale = false;
			_003CRenderLitItem_003Ed__.furniture = (FurnitureAppearance)0;
			_003CRenderLitItem_003Ed__.design = (Design)0;
			throw new NullReferenceException();
		}
	}
}
