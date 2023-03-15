using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using SoftMasking.Extensions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SoftMasking
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[AddComponentMenu("")]
	public class SoftMaskable : UIBehaviour, IMaterialModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private ISoftMask _mask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private Graphic _graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private Material _replacement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private bool _affectedByMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private bool _destroyed;

		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private static List<ISoftMask> s_softMasks = (List<ISoftMask>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private static List<Canvas> s_canvases;

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x32"), Cpp2IlInjected.Token(Token = "0x4000551")]
		public bool shaderIsNotSupported
		{
			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x997D80", Offset = "0x996780", VA = "0x180997D80")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x997DB0", Offset = "0x9967B0", VA = "0x180997DB0")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		public bool isMaskingEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x15FDD40", Offset = "0x15FC740", VA = "0x1815FDD40")]
			get
			{
				if (_mask != null && (object)typeof(ISoftMask).TypeHandle != null)
				{
					ISoftMask softMask = _mask;
					if ((object)typeof(ISoftMask).TypeHandle != null)
					{
						return _affectedByMask;
					}
				}
				int num = 0;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		public ISoftMask mask
		{
			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _mask;
			}
			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x15FDDC0", Offset = "0x15FC7C0", VA = "0x1815FDDC0")]
			private set
			{
				//IL_0018: Expected O, but got I4
				//IL_0029: Expected O, but got I4
				ISoftMask softMask = _mask;
				if (softMask != value)
				{
					if (softMask != null)
					{
						int num = 0;
						replacement = (Material)num;
					}
					int num2 = default(int);
					if (value == null || softMask == null)
					{
						num2 = 0;
					}
					_mask = (ISoftMask)num2;
					Invalidate();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		private Graphic graphic
		{
			[Cpp2IlInjected.Token(Token = "0x600079E")]
			[Cpp2IlInjected.Address(RVA = "0x15FDC80", Offset = "0x15FC680", VA = "0x1815FDC80")]
			get
			{
				bool flag = default(bool);
				if (flag)
				{
				}
				return _graphic = GetComponent<Graphic>();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		private Material replacement
		{
			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _replacement;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x15FDE60", Offset = "0x15FC860", VA = "0x1815FDE60")]
			set
			{
				bool flag = default(bool);
				if (!flag)
				{
					return;
				}
				bool flag2 = default(bool);
				if (flag2 && _mask != null)
				{
					int num = 0;
					uint num2 = default(uint);
					if (num < (int)num2)
					{
						num += num;
						num++;
					}
				}
				_replacement = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x15FD0A0", Offset = "0x15FBAA0", VA = "0x1815FD0A0", Slot = "17")]
		public Material GetModifiedMaterial(Material baseMaterial)
		{
			//IL_00df: Expected O, but got I4
			uint num2 = default(uint);
			while (true)
			{
				if (_mask != null && (object)typeof(ISoftMask).TypeHandle != null)
				{
					ISoftMask softMask = _mask;
					if ((object)typeof(ISoftMask).TypeHandle != null && _affectedByMask)
					{
						ISoftMask softMask2 = _mask;
						int num = 0;
						if (num < (int)num2)
						{
							num += num;
							num++;
						}
						if (!_replacement)
						{
							if (baseMaterial.HasDefaultUIShader() || shaderIsNotSupported)
							{
								break;
							}
							GameObject context = base.gameObject;
							object[] array = new object[2];
							Graphic graphic = this.graphic;
							if ((object)graphic != null && (object)graphic == null)
							{
								continue;
							}
							array[0] = graphic;
							if ((object)baseMaterial != null && (object)graphic == null)
							{
								continue;
							}
							array[1] = baseMaterial;
							Debug.LogWarningFormat(context, "SoftMask will not work on {0} because material {1} doesn't support masking. Add masking support to your material or set Graphic's material to None to use a default one.", array);
							shaderIsNotSupported = true;
						}
						shaderIsNotSupported = false;
					}
				}
				shaderIsNotSupported = false;
				int num3 = 0;
				replacement = (Material)num3;
				break;
			}
			return baseMaterial;
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x15FD3D0", Offset = "0x15FBDD0", VA = "0x1815FD3D0")]
		public void Invalidate()
		{
			//Discarded unreachable code: IL_001a
			if ((bool)graphic)
			{
				graphic.SetMaterialDirty();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x15FD550", Offset = "0x15FBF50", VA = "0x1815FD550")]
		public void MaskMightChanged()
		{
			if (FindMaskOrDie())
			{
				Invalidate();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x15FCE00", Offset = "0x15FB800", VA = "0x1815FCE00", Slot = "4")]
		protected override void Awake()
		{
			((object)this)._002Ector();
			base.hideFlags = HideFlags.HideInInspector;
		}

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x15FD900", Offset = "0x15FC300", VA = "0x1815FD900", Slot = "5")]
		protected override void OnEnable()
		{
			((object)this)._002Ector();
			if (FindMaskOrDie())
			{
				RequestChildTransformUpdate();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x15FD890", Offset = "0x15FC290", VA = "0x1815FD890", Slot = "7")]
		protected override void OnDisable()
		{
			//IL_001a: Expected O, but got I4
			//IL_0023: Expected O, but got I8
			((object)this)._002Ector();
			if ((long)_mask != 0)
			{
				int num = 0;
				replacement = (Material)num;
				_mask = (ISoftMask)0;
				Invalidate();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x15FD870", Offset = "0x15FC270", VA = "0x1815FD870", Slot = "8")]
		protected override void OnDestroy()
		{
			((object)this)._002Ector();
			_destroyed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x15FD850", Offset = "0x15FC250", VA = "0x1815FD850", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
			((object)this)._002Ector();
			bool flag = FindMaskOrDie();
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x15FD850", Offset = "0x15FC250", VA = "0x1815FD850", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
			((object)this)._002Ector();
			bool flag = FindMaskOrDie();
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x15FD940", Offset = "0x15FC340", VA = "0x1815FD940")]
		private void OnTransformChildrenChanged()
		{
			RequestChildTransformUpdate();
		}

		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x15FD950", Offset = "0x15FC350", VA = "0x1815FD950")]
		private void RequestChildTransformUpdate()
		{
			if (_mask != null)
			{
				Transform transform = base.transform;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x15FCE30", Offset = "0x15FB830", VA = "0x1815FCE30")]
		private bool FindMaskOrDie()
		{
			//IL_0038: Expected O, but got I4
			//IL_004c: Expected O, but got I4
			ISoftMask softMask = default(ISoftMask);
			int num2 = default(int);
			while (!_destroyed)
			{
				Transform transform = base.transform;
				if (softMask == null)
				{
					Transform transform2 = base.transform;
				}
				ISoftMask softMask2 = _mask;
				if (softMask2 != softMask)
				{
					if (softMask2 != null)
					{
						int num = 0;
						replacement = (Material)num;
					}
					if (softMask == null || softMask2 == null)
					{
						num2 = 0;
					}
					_mask = (ISoftMask)num2;
					Invalidate();
					if (_mask != null)
					{
						return true;
					}
					_destroyed = true;
					UnityEngine.Object.DestroyImmediate(this);
					break;
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x15FD580", Offset = "0x15FBF80", VA = "0x1815FD580")]
		private static ISoftMask NearestMask(Transform transform, out bool processedByThisMask, bool enabledOnly = true)
		{
			if ((bool)transform)
			{
				if (transform != transform)
				{
					List<ISoftMask> cpp2il__autoParamName__idx_ = s_softMasks;
					ISoftMask component = GetComponent<ISoftMask>(transform, (List<>)(object)cpp2il__autoParamName__idx_);
					if (component != null && component != null && (!enabledOnly || component != null))
					{
						goto IL_0059;
					}
				}
				List<Canvas> cpp2il__autoParamName__idx_2 = s_canvases;
				Canvas component2 = GetComponent<Canvas>(transform, (List<>)(object)cpp2il__autoParamName__idx_2);
				if (!component2 || component2.overrideSorting)
				{
				}
				Transform parent = transform.parent;
			}
			goto IL_0059;
			IL_0059:
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x15FCFC0", Offset = "0x15FB9C0", VA = "0x1815FCFC0")]
		private static ISoftMask GetISoftMask(Transform current, bool shouldBeEnabled = true)
		{
			List<ISoftMask> cpp2il__autoParamName__idx_ = s_softMasks;
			ISoftMask component = GetComponent<ISoftMask>(current, (List<>)(object)cpp2il__autoParamName__idx_);
			if (component != null && component != null && (!shouldBeEnabled || component != null))
			{
				return component;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x15FD470", Offset = "0x15FBE70", VA = "0x1815FD470")]
		private static bool IsOverridingSortingCanvas(Transform transform)
		{
			List<Canvas> cpp2il__autoParamName__idx_ = s_canvases;
			Canvas component = GetComponent<Canvas>(transform, (List<>)(object)cpp2il__autoParamName__idx_);
			if ((bool)component && component.overrideSorting)
			{
				return true;
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x1B24310", Offset = "0x1B22D10", VA = "0x181B24310")]
		private static T GetComponent<T>(Component cpp2il__autoParamName__idx_0, List<> cpp2il__autoParamName__idx_1) where T : class
		{
			//Discarded unreachable code: IL_002e
			int num = 0;
			if ((long)(IntPtr)typeof(IDisposable).TypeHandle > 0L)
			{
			}
			int num2 = 0;
			num2 += num2;
			if ((object)"{il2cpp array field il2cppMethodInfo->}" != (object)typeof(IDisposable).TypeHandle)
			{
				num2++;
			}
			num2 += 312;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x15FDA10", Offset = "0x15FC410", VA = "0x1815FDA10")]
		private void SetShaderNotSupported(Material material)
		{
			//Discarded unreachable code: IL_004b
			while (!shaderIsNotSupported)
			{
				GameObject context = base.gameObject;
				object[] array = new object[2];
				Graphic graphic = this.graphic;
				if ((object)graphic == null || (object)graphic != null)
				{
					array[0] = graphic;
					if ((object)material == null || (object)graphic != null)
					{
						array[1] = material;
						Debug.LogWarningFormat(context, "SoftMask will not work on {0} because material {1} doesn't support masking. Add masking support to your material or set Graphic's material to None to use a default one.", array);
						break;
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public SoftMaskable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x15FDBB0", Offset = "0x15FC5B0", VA = "0x1815FDBB0")]
		static SoftMaskable()
		{
			s_softMasks = (List<ISoftMask>)(object)new List<T>();
			/*Error: Unexpected end of block*/;
		}
	}
}
