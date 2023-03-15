using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;

namespace Mdl.Characters
{
	[Cpp2IlInjected.Token(Token = "0x2000848")]
	public class BlinkMode : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002E27")]
		[SerializeField]
		private List<GameObject> visualGameObjects = (List<GameObject>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002E28")]
		[ItemID]
		[SerializeField]
		private int activeWhen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4002E29")]
		[SerializeField]
		private float shownDurationMin = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002E2A")]
		[SerializeField]
		private float shownDurationMax = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4002E2B")]
		[SerializeField]
		private float hiddenDurationMin = 10f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4002E2C")]
		[SerializeField]
		private float hiddenDurationMax = 20f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4002E2D")]
		[SerializeField]
		private float fadeinDuration = 0.6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002E2E")]
		[SerializeField]
		private float fadeoutDuration = 0.6f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4002E2F")]
		[SerializeField]
		[ItemID]
		private int autoHideWhen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002E30")]
		[SerializeField]
		private float autoHideRadius = 5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4002E31")]
		[SerializeField]
		private bool stayTransparent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4002E32")]
		public bool? ForcedVisibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
		[Cpp2IlInjected.Token(Token = "0x4002E33")]
		private bool isActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002E34")]
		private bool mustAutoHide;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4002E35")]
		private bool shown = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4002E37")]
		private float progression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4002E38")]
		private float duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4002E39")]
		private List<Renderer> renderers = (List<Renderer>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4002E3A")]
		private List<bool> originalDithered;

		[Cpp2IlInjected.Token(Token = "0x4002E3B")]
		private static int fadeKey = Shader.PropertyToID("fade");

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4002E3C")]
		private float fadeProgression;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4002E3D")]
		private float fadeDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4002E3E")]
		private float fadeMinValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4002E3F")]
		private float fadeMaxValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4002E40")]
		private bool isFadingOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4002E41")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.Token(Token = "0x17000564")]
		private Item ActiveWhenItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002593")]
			[Cpp2IlInjected.Address(RVA = "0x1641600", Offset = "0x1640000", VA = "0x181641600")]
			get
			{
				long num = Convert.ToInt64((uint)activeWhen);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000565")]
		private bool HasActiveWhen
		{
			[Cpp2IlInjected.Token(Token = "0x6002594")]
			[Cpp2IlInjected.Address(RVA = "0x16417F0", Offset = "0x16401F0", VA = "0x1816417F0")]
			get
			{
				long num = Convert.ToInt64((uint)activeWhen);
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000566")]
		private Item AutoHideWhenItem
		{
			[Cpp2IlInjected.Token(Token = "0x6002595")]
			[Cpp2IlInjected.Address(RVA = "0x1641660", Offset = "0x1640060", VA = "0x181641660")]
			get
			{
				long num = Convert.ToInt64((uint)autoHideWhen);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000567")]
		private bool HasAutoHideWhen
		{
			[Cpp2IlInjected.Token(Token = "0x6002596")]
			[Cpp2IlInjected.Address(RVA = "0x16418B0", Offset = "0x16402B0", VA = "0x1816418B0")]
			get
			{
				long num = Convert.ToInt64((uint)autoHideWhen);
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000568")]
		public bool IsShown
		{
			[Cpp2IlInjected.Token(Token = "0x6002597")]
			[Cpp2IlInjected.Address(RVA = "0x162F5B0", Offset = "0x162DFB0", VA = "0x18162F5B0")]
			get
			{
				return shown;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000569")]
		private bool AvatarIsTooClose
		{
			[Cpp2IlInjected.Token(Token = "0x60025A3")]
			[Cpp2IlInjected.Address(RVA = "0x16416C0", Offset = "0x16400C0", VA = "0x1816416C0")]
			get
			{
				//Discarded unreachable code: IL_0036
				if (!mustAutoHide)
				{
					int num = 0;
				}
				Transform _003Ctransform_003Ek__BackingField = SystemRoot.Instance._avatar.transform;
				Vector3 vector = default(Vector3);
				float z = vector.z;
				Transform transform = base.transform;
				Vector3 vector2 = default(Vector3);
				float z2 = vector2.z;
				bool result = default(bool);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400005B")]
		public event EventHandler<bool> OnVisibilityChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6002598")]
			[Cpp2IlInjected.Address(RVA = "0x1641560", Offset = "0x163FF60", VA = "0x181641560")]
			[CompilerGenerated]
			add
			{
				EventHandler<bool> onVisibilityChanged = this.OnVisibilityChanged;
				Delegate @delegate = Delegate.Combine(onVisibilityChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onVisibilityChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6002599")]
			[Cpp2IlInjected.Address(RVA = "0x1641970", Offset = "0x1640370", VA = "0x181641970")]
			[CompilerGenerated]
			remove
			{
				EventHandler<bool> onVisibilityChanged = this.OnVisibilityChanged;
				Delegate @delegate = Delegate.Remove(onVisibilityChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onVisibilityChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600259A")]
		[Cpp2IlInjected.Address(RVA = "0x1640C50", Offset = "0x163F650", VA = "0x181640C50")]
		private void Start()
		{
			//Discarded unreachable code: IL_00f2
			//IL_000d: Expected I4, but got I8
			//IL_0099: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			ulong num4 = default(ulong);
			GhostMode[] componentsInChildren = GetComponentsInChildren<GhostMode>((byte)num4 != 0);
			int length = componentsInChildren.Length;
			if (num3 < length)
			{
				GhostMode ghostMode = componentsInChildren[num3];
				GhostMode.ChangingMaterial value = OnGhostChangingMaterial;
				ghostMode.OnChangingMaterial -= value;
				GhostMode.ChangingMaterial value2 = OnGhostChangingMaterial;
				ghostMode.OnChangingMaterial += value2;
				num3++;
			}
			int num5 = activeWhen;
			bool flag = default(bool);
			if (!flag)
			{
				return;
			}
			long num6 = Convert.ToInt64((uint)autoHideWhen);
			bool flag2 = default(bool);
			if (flag2)
			{
				List<PlayerTaskCollider.Condition> list = GetComponent<PlayerTaskCollider>().ActiveWhen;
				int condition = autoHideWhen;
				ulong num7 = default(ulong);
				PlayerTaskCollider.Condition item = new PlayerTaskCollider.Condition((byte)num7 != 0, condition);
				((List<T>)(object)list).Add((T)item);
			}
			List<GameObject> list2 = visualGameObjects;
			bool flag3 = default(bool);
			if (flag3)
			{
				List<Renderer> list3 = renderers;
				Func<Renderer, bool> func = default(Func<Renderer, bool>);
				if (_003C_003Ec._003C_003E9__39_0 == null)
				{
					func = (Func<Renderer, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(Renderer x)
					{
						int num9 = 0;
						if ((object)x != null)
						{
						}
						return num9 == 0;
					});
				}
				Renderer[] array = default(Renderer[]);
				IEnumerable<Renderer> enumerable = (IEnumerable<Renderer>)Enumerable.Where<Renderer>((IEnumerable<>)(object)array, (Func<, >)(object)func);
				((List<T>)(object)list3).AddRange((IEnumerable<>)enumerable);
			}
			int num8 = 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600259B")]
		[Cpp2IlInjected.Address(RVA = "0x16412C0", Offset = "0x163FCC0", VA = "0x1816412C0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0050, IL_0061, IL_0081, IL_00b2
			//IL_0074: Expected F4, but got I4
			//IL_007c: Expected F4, but got I4
			//IL_00a1: Expected F4, but got I4
			int num = 0;
			float deltaTime = Time.deltaTime;
			if (!FadeProgression(deltaTime))
			{
				progression = deltaTime;
				if (!(deltaTime <= duration))
				{
					int forced = 0;
					ToggleVisibility((byte)forced != 0);
				}
				if (shown && AvatarIsTooClose)
				{
					int forced2 = 0;
					ToggleVisibility((byte)forced2 != 0);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600259C")]
		[Cpp2IlInjected.Address(RVA = "0x1640A80", Offset = "0x163F480", VA = "0x181640A80")]
		private void OnDestroy()
		{
			//IL_0058: Expected O, but got I8
			GhostMode[] componentsInChildren = GetComponentsInChildren<GhostMode>(includeInactive: true);
			int num = 0;
			int num2 = 0;
			int length = componentsInChildren.Length;
			if (num < length)
			{
				GhostMode ghostMode = componentsInChildren[num2];
				GhostMode.ChangingMaterial value = OnGhostChangingMaterial;
				ghostMode.OnChangingMaterial -= value;
				num2++;
			}
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600259D")]
		[Cpp2IlInjected.Address(RVA = "0x1640BB0", Offset = "0x163F5B0", VA = "0x181640BB0")]
		private void OnGhostChangingMaterial(bool inGhostMode)
		{
			EnableTransparency();
		}

		[Cpp2IlInjected.Token(Token = "0x600259E")]
		[Cpp2IlInjected.Address(RVA = "0x163FD20", Offset = "0x163E720", VA = "0x18163FD20")]
		private void CreateEventHandler()
		{
			//IL_001a: Expected O, but got I4
			eventHandler?.Dispose();
			int num = 0;
			eventHandler = (ConditionEventHandler)num;
			long num2 = Convert.ToInt64((uint)activeWhen);
			long num3 = Convert.ToInt64((uint)autoHideWhen);
			if (SystemRoot.Instance.MetaClient.Dispatcher != null)
			{
				ProfileEventDispatcher.AnyConditionChanged anyConditionChanged = OnAnyConditionChanged;
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600259F")]
		[Cpp2IlInjected.Address(RVA = "0x1640170", Offset = "0x163EB70", VA = "0x181640170")]
		private void DisposeEventHandler()
		{
			while (true)
			{
				if ((object)this != null)
				{
					/*Error: Could not find block for branch target IL_0004*/;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025A0")]
		[Cpp2IlInjected.Address(RVA = "0x16406B0", Offset = "0x163F0B0", VA = "0x1816406B0")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			int num = activeWhen;
			Client metaClient = SystemRoot.Instance.MetaClient;
			Client metaClient2 = SystemRoot.Instance.MetaClient;
			bool flag = default(bool);
			isActive = flag;
			if (!HasAutoHideWhen)
			{
			}
			int num2 = autoHideWhen;
			Client metaClient3 = SystemRoot.Instance.MetaClient;
			Client metaClient4 = SystemRoot.Instance.MetaClient;
			bool flag2 = default(bool);
			mustAutoHide = flag2;
			bool flag3 = isActive;
			bool flag4 = base.enabled;
			if (flag3 != flag4)
			{
				if (isActive)
				{
					base.enabled = true;
					int forced = 0;
					ToggleVisibility((byte)forced != 0);
					throw new NullReferenceException();
				}
				DisableTransparency();
				int num3 = ((base.enabled = false) ? 1 : 0);
				if (!shown)
				{
					ChangeVisibility(show: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025A1")]
		[Cpp2IlInjected.Address(RVA = "0x163FB60", Offset = "0x163E560", VA = "0x18163FB60")]
		private void Activate()
		{
			base.enabled = true;
			int forced = 0;
			ToggleVisibility((byte)forced != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60025A2")]
		[Cpp2IlInjected.Address(RVA = "0x163FF70", Offset = "0x163E970", VA = "0x18163FF70")]
		private void Deactivate()
		{
			DisableTransparency();
			int num = ((base.enabled = false) ? 1 : 0);
			if (!shown)
			{
				ChangeVisibility(show: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025A4")]
		[Cpp2IlInjected.Address(RVA = "0x16411B0", Offset = "0x163FBB0", VA = "0x1816411B0")]
		private unsafe void ToggleVisibility(bool forced = false)
		{
			//Discarded unreachable code: IL_00b8
			//IL_001e: Expected F4, but got I4
			//IL_0053: Expected F4, but got I4
			//IL_0065: Expected F4, but got I4
			//IL_0092: Expected F4, but got I4
			int num = 0;
			bool flag = default(bool);
			if (!forced && TryGetComponent<Character>(out *(Character*)num) && flag)
			{
				return;
			}
			progression = num;
			if ((shown ? 1 : 0) == num)
			{
				if (!forced && AvatarIsTooClose)
				{
					return;
				}
				float num2 = (fadeDuration = fadeinDuration);
				isFadingOut = (byte)num != 0;
				fadeMinValue = num;
				fadeMaxValue = 1f;
				fadeProgression = num;
				EnableTransparency();
			}
			float num3 = (fadeDuration = fadeoutDuration);
			isFadingOut = true;
			fadeMinValue = 1f;
			fadeProgression = num;
			EnableTransparency();
			float maxInclusive = hiddenDurationMax;
			float num4 = (duration = UnityEngine.Random.Range(hiddenDurationMin, maxInclusive));
		}

		[Cpp2IlInjected.Token(Token = "0x60025A5")]
		[Cpp2IlInjected.Address(RVA = "0x1640BC0", Offset = "0x163F5C0", VA = "0x181640BC0")]
		private void Show()
		{
			if (!shown)
			{
				ChangeVisibility(show: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025A6")]
		[Cpp2IlInjected.Address(RVA = "0x1640690", Offset = "0x163F090", VA = "0x181640690")]
		private void Hide()
		{
			if (shown)
			{
				int show = 0;
				ChangeVisibility((byte)show != 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025A7")]
		[Cpp2IlInjected.Address(RVA = "0x163FB90", Offset = "0x163E590", VA = "0x18163FB90")]
		private void ChangeVisibility(bool show)
		{
			//Discarded unreachable code: IL_0017, IL_001d
			shown = show;
			List<GameObject> list = visualGameObjects;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025A8")]
		[Cpp2IlInjected.Address(RVA = "0x1640BE0", Offset = "0x163F5E0", VA = "0x181640BE0")]
		private void StartFadeIn()
		{
			//IL_0017: Expected F4, but got I4
			//IL_001e: Expected F4, but got I4
			float num = (fadeDuration = fadeinDuration);
			int num2 = 0;
			fadeMinValue = num2;
			fadeProgression = num2;
			isFadingOut = false;
			fadeMaxValue = 1f;
			EnableTransparency();
		}

		[Cpp2IlInjected.Token(Token = "0x60025A9")]
		[Cpp2IlInjected.Address(RVA = "0x1640C10", Offset = "0x163F610", VA = "0x181640C10")]
		private void StartFadeOut()
		{
			//IL_0017: Expected F4, but got I4
			float num = (fadeDuration = fadeoutDuration);
			int num2 = 0;
			fadeProgression = num2;
			isFadingOut = true;
			fadeMinValue = 1f;
			EnableTransparency();
		}

		[Cpp2IlInjected.Token(Token = "0x60025AA")]
		[Cpp2IlInjected.Address(RVA = "0x1640C40", Offset = "0x163F640", VA = "0x181640C40")]
		private void StartFadeProgression()
		{
			fadeProgression = 0f;
			EnableTransparency();
		}

		[Cpp2IlInjected.Token(Token = "0x60025AB")]
		[Cpp2IlInjected.Address(RVA = "0x1641190", Offset = "0x163FB90", VA = "0x181641190")]
		private void StopFadeProgression()
		{
			if (!stayTransparent || isFadingOut)
			{
				DisableTransparency();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025AC")]
		[Cpp2IlInjected.Address(RVA = "0x1640420", Offset = "0x163EE20", VA = "0x181640420")]
		private bool FadeProgression(float deltaTime)
		{
			//Discarded unreachable code: IL_0062, IL_0068, IL_006e, IL_0074
			//IL_000d: Invalid comparison between F4 and I4
			int num = 0;
			float num2 = fadeDuration;
			int num3 = 0;
			if (!(num2 > (float)num3))
			{
			}
			if ((shown ? 1 : 0) == num)
			{
				ChangeVisibility(show: true);
			}
			float num4 = (fadeProgression = fadeProgression);
			if (!(num4 > num2))
			{
				float b = fadeMaxValue;
				float num5 = Mathf.Lerp(fadeMinValue, b, num4);
				List<Renderer> list = renderers;
				bool flag = default(bool);
				if (flag)
				{
					num4 = num5;
					num++;
				}
			}
			int num6 = 0;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60025AD")]
		[Cpp2IlInjected.Address(RVA = "0x16401B0", Offset = "0x163EBB0", VA = "0x1816401B0")]
		private void EnableTransparency()
		{
			//Discarded unreachable code: IL_002d, IL_0033, IL_0039, IL_003f, IL_0045
			//IL_0028: Expected O, but got I4
			int num = 0;
			List<bool> list = (originalDithered = (List<bool>)(object)new List<T>());
			List<Renderer> list2 = renderers;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				((List<T>)(object)originalDithered).Add((T)flag2);
				num++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025AE")]
		[Cpp2IlInjected.Address(RVA = "0x163FFB0", Offset = "0x163E9B0", VA = "0x18163FFB0")]
		private void DisableTransparency()
		{
			//Discarded unreachable code: IL_0034, IL_003a, IL_0040, IL_0046, IL_004c, IL_0052
			int num = 0;
			if ((IntPtr)originalDithered == (IntPtr)num)
			{
				return;
			}
			int num2 = 0;
			List<Renderer> list = renderers;
			bool flag = default(bool);
			if (flag)
			{
				int num3 = 0;
				List<bool> list2 = originalDithered;
				if (!flag)
				{
				}
				num3++;
				num2++;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60025AF")]
		[Cpp2IlInjected.Address(RVA = "0x1641470", Offset = "0x163FE70", VA = "0x181641470")]
		public BlinkMode()
		{
		}
	}
}
