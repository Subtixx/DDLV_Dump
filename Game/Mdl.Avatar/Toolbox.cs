using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Conditions;
using Definitions.Items;
using Gameloft.Common;
using Mdl.Ftue.Cutscenes;
using Mdl.Online;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Online;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Mdl.Avatar
{
	[Cpp2IlInjected.Token(Token = "0x2000A8F")]
	public class Toolbox : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000A90")]
		public enum ToolType
		{
			[Cpp2IlInjected.Token(Token = "0x4003A24")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4003A25")]
			WateringCan,
			[Cpp2IlInjected.Token(Token = "0x4003A26")]
			FishingRod,
			[Cpp2IlInjected.Token(Token = "0x4003A27")]
			GardeningShovel,
			[Cpp2IlInjected.Token(Token = "0x4003A28")]
			Pickaxe,
			[Cpp2IlInjected.Token(Token = "0x4003A29")]
			CameraTool
		}

		[Cpp2IlInjected.Token(Token = "0x2000A91")]
		public enum ToolAttachmentPointType
		{
			[Cpp2IlInjected.Token(Token = "0x4003A2B")]
			LeftHand,
			[Cpp2IlInjected.Token(Token = "0x4003A2C")]
			VisualRoot
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000A92")]
		public class ToolAttachmentPoint
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4003A2D")]
			public ToolAttachmentPointType attachmentPointType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4003A2E")]
			public Transform transform;

			[Cpp2IlInjected.Token(Token = "0x60030DF")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public ToolAttachmentPoint()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A93")]
		public struct TemporarySwitchToolScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003A2F")]
			private readonly Toolbox toolbox;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4003A30")]
			private readonly ToolType previousToolType;

			[Cpp2IlInjected.Token(Token = "0x170006D6")]
			public bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x60030E0")]
				[Cpp2IlInjected.Address(RVA = "0x1413D50", Offset = "0x1412750", VA = "0x181413D50")]
				get
				{
					bool result = default(bool);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60030E1")]
			[Cpp2IlInjected.Address(RVA = "0x1413CD0", Offset = "0x14126D0", VA = "0x181413CD0")]
			public TemporarySwitchToolScope(Toolbox toolbox, ToolType newToolType, bool cancelUnequip)
			{
				//Discarded unreachable code: IL_0022
				this.toolbox = toolbox;
				ToolType toolType = (previousToolType = toolbox._currentToolType);
				int num = 0;
				if (cancelUnequip)
				{
					toolbox.CancelUnequip();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60030E2")]
			[Cpp2IlInjected.Address(RVA = "0x1413C50", Offset = "0x1412650", VA = "0x181413C50", Slot = "4")]
			public void Dispose()
			{
				//Discarded unreachable code: IL_000c
				bool flag = default(bool);
				if (flag)
				{
					ToolType toolType = previousToolType;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000A94")]
		public struct TemporaryHideToolScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4003A31")]
			private Toolbox toolbox;

			[Cpp2IlInjected.Token(Token = "0x170006D7")]
			public bool IsValid
			{
				[Cpp2IlInjected.Token(Token = "0x60030E3")]
				[Cpp2IlInjected.Address(RVA = "0x1413BF0", Offset = "0x14125F0", VA = "0x181413BF0")]
				get
				{
					bool result = default(bool);
					return result;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60030E4")]
			[Cpp2IlInjected.Address(RVA = "0x1413BD0", Offset = "0x14125D0", VA = "0x181413BD0")]
			public TemporaryHideToolScope(Toolbox toolbox)
			{
				this.toolbox = toolbox;
				HideCurrentTool();
			}

			[Cpp2IlInjected.Token(Token = "0x60030E5")]
			[Cpp2IlInjected.Address(RVA = "0x14138D0", Offset = "0x14122D0", VA = "0x1814138D0", Slot = "4")]
			public void Dispose()
			{
				bool flag = default(bool);
				if (flag)
				{
					ShowCurrentTool();
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60030E6")]
			[Cpp2IlInjected.Address(RVA = "0x1413960", Offset = "0x1412360", VA = "0x181413960")]
			private void HideCurrentTool()
			{
				//Discarded unreachable code: IL_001e
				PlayerAvatar avatar = SystemRoot.Instance._avatar;
				int sendTrigger = 0;
				Tool tool = default(Tool);
				CancellationToken ct = default(CancellationToken);
				tool.UnEquip(avatar, (byte)sendTrigger != 0, ct).FireAndForgetTask();
			}

			[Cpp2IlInjected.Token(Token = "0x60030E7")]
			[Cpp2IlInjected.Address(RVA = "0x1413AB0", Offset = "0x14124B0", VA = "0x181413AB0")]
			private void ShowCurrentTool()
			{
				//Discarded unreachable code: IL_0019
				PlayerAvatar avatar = SystemRoot.Instance._avatar;
				int sendTrigger = 0;
				Tool tool = default(Tool);
				CancellationToken ct = default(CancellationToken);
				tool.Equip(avatar, (byte)sendTrigger != 0, ct);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4003A15")]
		[SerializeField]
		private ToolAttachmentPoint[] _toolAttachmentPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4003A16")]
		[SerializeField]
		private GameObject _selectingToolVFXPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4003A17")]
		private GameObject selectingToolVFXInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4003A18")]
		[SerializeField]
		private string _selectingToolVFXEndTrigger = "out";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4003A19")]
		[SerializeField]
		private AssetReferenceGameObject _unlockToolCutsceneReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4003A1A")]
		private CustomTimelineCutscene unlockToolCutscene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4003A1B")]
		private ConditionEventHandler eventHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4003A1C")]
		private List<CustomTimelineCutscene.ItemPrefabMap> lockedTools = (List<CustomTimelineCutscene.ItemPrefabMap>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4003A1D")]
		private readonly Dictionary<ToolType, Tool> toolsByType = (Dictionary<ToolType, Tool>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4003A1E")]
		private ToolType _currentToolType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4003A1F")]
		private bool _isSelectingTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4003A22")]
		private CancellationTokenSource toolUsageCTS = new CancellationTokenSource();

		[Cpp2IlInjected.Token(Token = "0x170006D0")]
		public IEnumerable<Tool> AllTools
		{
			[Cpp2IlInjected.Token(Token = "0x60030BD")]
			[Cpp2IlInjected.Address(RVA = "0x13DAFD0", Offset = "0x13D99D0", VA = "0x1813DAFD0")]
			get
			{
				Dictionary<ToolType, Tool> dictionary = toolsByType;
				Func<KeyValuePair<ToolType, Tool>, Tool> _003C_003E9__14_ = _003C_003Ec._003C_003E9__14_0;
				if (_003C_003E9__14_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				return (IEnumerable<Tool>)Enumerable.Select<KeyValuePair<ToolType, Tool>, Tool>((IEnumerable<>)dictionary, (Func<, >)(object)_003C_003E9__14_);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D1")]
		public Tool CurrentTool
		{
			[Cpp2IlInjected.Token(Token = "0x60030BE")]
			[Cpp2IlInjected.Address(RVA = "0x13DB100", Offset = "0x13D9B00", VA = "0x1813DB100")]
			get
			{
				//IL_0016: Expected O, but got I4
				int num = 0;
				ToolType currentToolType = _currentToolType;
				ToolType valueOrDefault = MoreLinq.GetValueOrDefault<ToolType, Tool>((IReadOnlyDictionary<, >)toolsByType, (Tool)currentToolType, (ToolType)num);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D2")]
		public bool IsUsingTool
		{
			[Cpp2IlInjected.Token(Token = "0x60030BF")]
			[Cpp2IlInjected.Address(RVA = "0x13DB370", Offset = "0x13D9D70", VA = "0x1813DB370")]
			get
			{
				//Discarded unreachable code: IL_0049
				//IL_0016: Expected O, but got I4
				//IL_003c: Expected O, but got I4
				int num = 0;
				ToolType currentToolType = _currentToolType;
				ToolType valueOrDefault = MoreLinq.GetValueOrDefault<ToolType, Tool>((IReadOnlyDictionary<, >)toolsByType, (Tool)currentToolType, (ToolType)num);
				bool flag = default(bool);
				if (!flag)
				{
					int num2 = 0;
				}
				int num3 = 0;
				ToolType currentToolType2 = _currentToolType;
				Dictionary<ToolType, Tool> dictionary = toolsByType;
				ToolType valueOrDefault2 = MoreLinq.GetValueOrDefault<ToolType, Tool>((IReadOnlyDictionary<, >)dictionary, (Tool)currentToolType2, (ToolType)num3);
				while (dictionary == null)
				{
				}
				bool flag2 = default(bool);
				return !flag2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D3")]
		public bool IsChangingTool
		{
			[Cpp2IlInjected.Token(Token = "0x60030C0")]
			[Cpp2IlInjected.Address(RVA = "0x13DB140", Offset = "0x13D9B40", VA = "0x1813DB140")]
			get
			{
				Dictionary<ToolType, Tool> dictionary = toolsByType;
				Func<KeyValuePair<ToolType, Tool>, Tool> _003C_003E9__14_ = _003C_003Ec._003C_003E9__14_0;
				if (_003C_003E9__14_ == null)
				{
					_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate
					{
						throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
					};
				}
				IEnumerable<KeyValuePair<ToolType, Tool>> cpp2il__autoParamName__idx_ = (IEnumerable<KeyValuePair<ToolType, Tool>>)Enumerable.Select<KeyValuePair<ToolType, Tool>, Tool>((IEnumerable<>)dictionary, (Func<, >)(object)_003C_003E9__14_);
				Func<Tool, bool> cpp2il__autoParamName__idx_2 = default(Func<Tool, bool>);
				if (_003C_003Ec._003C_003E9__20_0 == null)
				{
					cpp2il__autoParamName__idx_2 = (Func<Tool, bool>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((Tool x) => x.IsEquippingTool || x.IsUnequippingTool));
				}
				return ((IEnumerable<>)cpp2il__autoParamName__idx_).Any<Tool>((Func<, >)(object)cpp2il__autoParamName__idx_2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D4")]
		public ToolType CurrentToolType
		{
			[Cpp2IlInjected.Token(Token = "0x60030C1")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A150", VA = "0x180A5B750")]
			get
			{
				return _currentToolType;
			}
			[Cpp2IlInjected.Token(Token = "0x60030C2")]
			[Cpp2IlInjected.Address(RVA = "0x13DB5B0", Offset = "0x13D9FB0", VA = "0x1813DB5B0")]
			set
			{
				//Discarded unreachable code: IL_0094, IL_012a
				//IL_0018: Expected O, but got I4
				//IL_003c: Expected O, but got I4
				//IL_00b7: Expected O, but got I4
				//IL_00f2: Expected O, but got I4
				//IL_0129: Expected O, but got I4
				int num = 0;
				ToolType currentToolType = _currentToolType;
				ToolType valueOrDefault = MoreLinq.GetValueOrDefault<ToolType, Tool>((IReadOnlyDictionary<, >)toolsByType, (Tool)currentToolType, (ToolType)num);
				bool flag = default(bool);
				if (flag)
				{
					int num2 = 0;
					ToolType currentToolType2 = _currentToolType;
					Dictionary<ToolType, Tool> dictionary = toolsByType;
					ToolType valueOrDefault2 = MoreLinq.GetValueOrDefault<ToolType, Tool>((IReadOnlyDictionary<, >)dictionary, (Tool)currentToolType2, (ToolType)num2);
					bool flag2 = default(bool);
					if (dictionary != null && !flag2)
					{
						return;
					}
				}
				CurseSystem curseSystem = default(CurseSystem);
				if (SystemRoot.Instance._avatar.RelaxingBehaviour.Relaxing || (value != 0 && curseSystem.isLimboActive) || _currentToolType == value)
				{
					return;
				}
				if (value != 0)
				{
					Dictionary<ToolType, Tool> dictionary2 = toolsByType;
					throw new NullReferenceException();
				}
				Tool currentTool = CurrentTool;
				_currentToolType = value;
				int num3 = 0;
				if (currentTool != (UnityEngine.Object)num3)
				{
					int num4 = 0;
					if ((_isSelectingTool ? 1 : 0) == num4)
					{
					}
					CancellationToken token = toolUsageCTS.Token;
					int num5 = 0;
					Task asyncTask = default(Task);
					asyncTask.FireAndForgetTask();
				}
				Tool currentTool2 = CurrentTool;
				int num6 = 0;
				if (currentTool2 != (UnityEngine.Object)num6)
				{
					Tool currentTool3 = CurrentTool;
					CancellationToken token2 = toolUsageCTS.Token;
				}
				EventHandler<ToolType> currentToolChanged = this.CurrentToolChanged;
				if (currentToolChanged != null)
				{
					ToolType currentToolType3 = _currentToolType;
					currentToolChanged(this, (TEventArgs)currentToolType3);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006D5")]
		public bool IsSelectingTool
		{
			[Cpp2IlInjected.Token(Token = "0x60030C3")]
			[Cpp2IlInjected.Address(RVA = "0xD247C0", Offset = "0xD231C0", VA = "0x180D247C0")]
			get
			{
				return _isSelectingTool;
			}
			[Cpp2IlInjected.Token(Token = "0x60030C4")]
			[Cpp2IlInjected.Address(RVA = "0x13DBB30", Offset = "0x13DA530", VA = "0x1813DBB30")]
			set
			{
				//Discarded unreachable code: IL_00d4
				//IL_0028: Expected O, but got I4
				//IL_004e: Expected O, but got I4
				//IL_00d3: Expected O, but got I4
				int num = 0;
				if (_isSelectingTool == value)
				{
					return;
				}
				Task task = default(Task);
				if (value)
				{
					int num2 = 0;
					ToolType currentToolType = _currentToolType;
					ToolType valueOrDefault = MoreLinq.GetValueOrDefault<ToolType, Tool>((IReadOnlyDictionary<, >)toolsByType, (Tool)currentToolType, (ToolType)num2);
					bool flag = default(bool);
					if (!flag)
					{
						StartToolSelection();
					}
					int num3 = 0;
					ToolType currentToolType2 = _currentToolType;
					ToolType valueOrDefault2 = MoreLinq.GetValueOrDefault<ToolType, Tool>((IReadOnlyDictionary<, >)toolsByType, (Tool)currentToolType2, (ToolType)num3);
					CancellationToken token = toolUsageCTS.Token;
					int num4 = 0;
					task.FireAndForgetTask();
				}
				_isSelectingTool = value;
				if (value)
				{
					return;
				}
				TaskScheduler taskScheduler = task.m_taskScheduler;
				Animator animator = default(Animator);
				animator.ResetTrigger("ToolSelection");
				int num5 = 0;
				int value2 = 0;
				Animator animator2 = default(Animator);
				animator2.SetBool("IsSelectingTool", (byte)value2 != 0);
				int num6 = 0;
				bool flag2 = default(bool);
				if (!flag2)
				{
					return;
				}
				int num7 = 0;
				bool flag3 = default(bool);
				bool flag4 = default(bool);
				if (flag3 && flag4)
				{
					string selectingToolVFXEndTrigger = _selectingToolVFXEndTrigger;
					if (!flag4)
					{
						GameObject gameObject = default(GameObject);
						DestroyOnEnable destroyOnEnable = gameObject.AddComponent<DestroyOnEnable>();
					}
				}
				UnityEngine.Object.Destroy(this);
				selectingToolVFXInstance = (GameObject)num;
				[Cpp2IlInjected.Token(Token = "0x60030DC")]
				[Cpp2IlInjected.Address(RVA = "0x13DAA20", Offset = "0x13D9420", VA = "0x1813DAA20")]
				void StartToolSelection()
				{
					//Discarded unreachable code: IL_0092
					//IL_005c: Expected O, but got I4
					SystemRoot.Instance._avatar.Animator.ResetTrigger("Exit");
					SystemRoot.Instance._avatar.Animator.SetBool("IsSelectingTool", value: true);
					SystemRoot.Instance._avatar.Animator.SetTrigger("ToolSelection");
					GameObject selectingToolVFXPrefab = _selectingToolVFXPrefab;
					int num8 = 0;
					if (selectingToolVFXPrefab != (UnityEngine.Object)num8)
					{
						GameObject selectingToolVFXPrefab2 = _selectingToolVFXPrefab;
						Transform parent = SystemRoot.Instance._avatar.CharacterVisualNodes.LeftHand.transform;
						GameObject gameObject2 = (selectingToolVFXInstance = UnityEngine.Object.Instantiate(selectingToolVFXPrefab2, parent));
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007E")]
		public event EventHandler<ToolType> CurrentToolChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60030C5")]
			[Cpp2IlInjected.Address(RVA = "0x13DAE90", Offset = "0x13D9890", VA = "0x1813DAE90")]
			[CompilerGenerated]
			add
			{
				EventHandler<ToolType> currentToolChanged = this.CurrentToolChanged;
				Delegate @delegate = Delegate.Combine(currentToolChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != currentToolChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60030C6")]
			[Cpp2IlInjected.Address(RVA = "0x13DB470", Offset = "0x13D9E70", VA = "0x1813DB470")]
			[CompilerGenerated]
			remove
			{
				EventHandler<ToolType> currentToolChanged = this.CurrentToolChanged;
				Delegate @delegate = Delegate.Remove(currentToolChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != currentToolChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400007F")]
		public event EventHandler<GameObject> ToolInteractedWithObjectEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60030C7")]
			[Cpp2IlInjected.Address(RVA = "0x13DAF30", Offset = "0x13D9930", VA = "0x1813DAF30")]
			[CompilerGenerated]
			add
			{
				EventHandler<GameObject> toolInteractedWithObjectEvent = this.ToolInteractedWithObjectEvent;
				Delegate @delegate = Delegate.Combine(toolInteractedWithObjectEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != toolInteractedWithObjectEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x60030C8")]
			[Cpp2IlInjected.Address(RVA = "0x13DB510", Offset = "0x13D9F10", VA = "0x1813DB510")]
			[CompilerGenerated]
			remove
			{
				EventHandler<GameObject> toolInteractedWithObjectEvent = this.ToolInteractedWithObjectEvent;
				Delegate @delegate = Delegate.Remove(toolInteractedWithObjectEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != toolInteractedWithObjectEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030BC")]
		[Cpp2IlInjected.Address(RVA = "0x13D9210", Offset = "0x13D7C10", VA = "0x1813D9210")]
		public Transform GetToolAttachment(ToolAttachmentPointType toolAttachmentPointType)
		{
			ToolAttachmentPoint[] toolAttachmentPoints = _toolAttachmentPoints;
			Func<ToolAttachmentPoint, bool> func = (Func<ToolAttachmentPoint, bool>)(object)(Func<T, TResult>)delegate(ToolAttachmentPoint x)
			{
				//Discarded unreachable code: IL_0011
				ToolAttachmentPointType toolAttachmentPointType2 = toolAttachmentPointType;
				return x.attachmentPointType == toolAttachmentPointType2;
			};
			ToolAttachmentPoint toolAttachmentPoint = Enumerable.FirstOrDefault<ToolAttachmentPoint>((IEnumerable<>)(object)toolAttachmentPoints, (Func<, >)(object)func);
			if (toolAttachmentPoint != null)
			{
				return toolAttachmentPoint.transform;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030C9")]
		[Cpp2IlInjected.Address(RVA = "0x13DA520", Offset = "0x13D8F20", VA = "0x1813DA520")]
		private void RaiseCurrentToolChanged()
		{
			//IL_001a: Expected O, but got I4
			EventHandler<ToolType> currentToolChanged = this.CurrentToolChanged;
			if (currentToolChanged != null)
			{
				ToolType currentToolType = _currentToolType;
				currentToolChanged(this, (TEventArgs)currentToolType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030CA")]
		[Cpp2IlInjected.Address(RVA = "0x13DA570", Offset = "0x13D8F70", VA = "0x1813DA570")]
		private void Start()
		{
			//Discarded unreachable code: IL_0025
			ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
			ProfileEventDispatcher.ToolAdded value = OnToolAdded;
			_003CDispatcher_003Ek__BackingField.OnToolAdded += value;
		}

		[Cpp2IlInjected.Token(Token = "0x60030CB")]
		[Cpp2IlInjected.Address(RVA = "0x13D9900", Offset = "0x13D8300", VA = "0x1813D9900")]
		private void OnDestroy()
		{
			//IL_0061: Expected O, but got I8
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Meta.Online.Client metaClient = _003CInstance_003Ek__BackingField.MetaClient;
				if (metaClient != null && (long)metaClient.Dispatcher != 0)
				{
					ProfileEventDispatcher _003CDispatcher_003Ek__BackingField = SystemRoot.Instance.MetaClient.Dispatcher;
					ProfileEventDispatcher.ToolAdded value = OnToolAdded;
					_003CDispatcher_003Ek__BackingField.OnToolAdded -= value;
				}
			}
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60030CC")]
		[Cpp2IlInjected.Address(RVA = "0x13D9B90", Offset = "0x13D8590", VA = "0x1813D9B90")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_004f
			//IL_001f: Expected O, but got I4
			//IL_0043: Expected O, but got I4
			if (_currentToolType != 0)
			{
				ToolType currentToolType = _currentToolType;
				int num = 0;
				ToolType valueOrDefault = MoreLinq.GetValueOrDefault<ToolType, Tool>((IReadOnlyDictionary<, >)toolsByType, (Tool)currentToolType, (ToolType)num);
				GameObject gameObject = default(GameObject);
				if (!gameObject.activeSelf)
				{
					int num2 = 0;
					ToolType currentToolType2 = _currentToolType;
					ToolType valueOrDefault2 = MoreLinq.GetValueOrDefault<ToolType, Tool>((IReadOnlyDictionary<, >)toolsByType, (Tool)currentToolType2, (ToolType)num2);
					GameObject gameObject2 = default(GameObject);
					gameObject2.SetActive(value: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030CD")]
		[Cpp2IlInjected.Address(RVA = "0x13D9B20", Offset = "0x13D8520", VA = "0x1813D9B20")]
		private void OnDisable()
		{
			if (!IsChangingTool)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030CE")]
		[Cpp2IlInjected.Address(RVA = "0x13D9500", Offset = "0x13D7F00", VA = "0x1813D9500")]
		[AsyncStateMachine(typeof(_003CLoadToolsFromProfile_003Ed__41))]
		internal Task LoadToolsFromProfile(Profile profile)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60030CF")]
		[Cpp2IlInjected.Address(RVA = "0x13D9CC0", Offset = "0x13D86C0", VA = "0x1813D9CC0")]
		private void OnToolAdded(Item toolItem)
		{
			//Discarded unreachable code: IL_0012
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			int num = 0;
			int num2 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x60030D0")]
		[Cpp2IlInjected.Address(RVA = "0x13D93D0", Offset = "0x13D7DD0", VA = "0x1813D93D0")]
		[AsyncStateMachine(typeof(_003CLoadTool_003Ed__43))]
		private Task LoadTool(ToolItemData toolItemData)
		{
			int num = 0;
			int num2 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D1")]
		[Cpp2IlInjected.Address(RVA = "0x13D9EE0", Offset = "0x13D88E0", VA = "0x1813D9EE0")]
		private void OnToolInteractedWithObjectEvent(object sender, GameObject e)
		{
			((EventHandler<TEventArgs>)(object)this.ToolInteractedWithObjectEvent)?.Invoke(sender, (TEventArgs)e);
		}

		[Cpp2IlInjected.Token(Token = "0x60030D2")]
		[Cpp2IlInjected.Address(RVA = "0x13D8C30", Offset = "0x13D7630", VA = "0x1813D8C30")]
		private void CancelUnequip()
		{
			//Discarded unreachable code: IL_001a
			SystemRoot.Instance._avatar.Animator.ResetTrigger("ToolUnequip");
		}

		[Cpp2IlInjected.Token(Token = "0x60030D3")]
		[Cpp2IlInjected.Address(RVA = "0x13DA6A0", Offset = "0x13D90A0", VA = "0x1813DA6A0")]
		public TemporarySwitchToolScope SwitchTool(ToolType newToolType, bool cancelUnEquip = false, params ToolType[] unlessTools)
		{
			bool flag = default(bool);
			if ((cancelUnEquip ? ToolType.WateringCan : ToolType.None) != newToolType && !flag)
			{
				int num = 0;
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D4")]
		[Cpp2IlInjected.Address(RVA = "0x13D9300", Offset = "0x13D7D00", VA = "0x1813D9300")]
		public TemporaryHideToolScope HideTool()
		{
			//IL_0016: Expected O, but got I4
			int num = 0;
			ToolType currentToolType = _currentToolType;
			ToolType valueOrDefault = MoreLinq.GetValueOrDefault<ToolType, Tool>((IReadOnlyDictionary<, >)toolsByType, (Tool)currentToolType, (ToolType)num);
			bool flag = default(bool);
			if (!flag)
			{
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D5")]
		[Cpp2IlInjected.Address(RVA = "0x13D8D50", Offset = "0x13D7750", VA = "0x1813D8D50")]
		private void CreateEventHandler()
		{
			//Discarded unreachable code: IL_0088, IL_008e, IL_0094, IL_009a, IL_00a0, IL_00a6, IL_00ac
			//IL_001a: Expected O, but got I4
			//IL_0035: Expected O, but got I4
			int num = 0;
			eventHandler?.Dispose();
			eventHandler = (ConditionEventHandler)num;
			((List<T>)(object)lockedTools).Clear();
			CustomTimelineCutscene customTimelineCutscene = unlockToolCutscene;
			int num2 = 0;
			if (!(customTimelineCutscene != (UnityEngine.Object)num2))
			{
				return;
			}
			List<int> list = (List<int>)(object)new List<T>();
			List<CustomTimelineCutscene.ItemPrefabMap> itemPrefabMap = unlockToolCutscene.itemPrefabMap;
			bool flag = default(bool);
			if (flag)
			{
				Meta.Online.Client client = default(Meta.Online.Client);
				ProfilePlayer player_ = client.profile.player_;
				bool flag2 = default(bool);
				while (flag2)
				{
				}
				List<CustomTimelineCutscene.ItemPrefabMap> list2 = lockedTools;
			}
			Meta.Online.Client client2 = default(Meta.Online.Client);
			if (client2.Dispatcher != null)
			{
				ConditionListener mask = ConditionItemData.GetMask((IEnumerable<>)list);
			}
			ConditionEventHandler conditionEventHandler = default(ConditionEventHandler);
			eventHandler = conditionEventHandler;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D6")]
		[Cpp2IlInjected.Address(RVA = "0x13D9630", Offset = "0x13D8030", VA = "0x1813D9630")]
		private void OnAnyConditionChanged(ConditionListener conditionListener)
		{
			int num = 0;
			SystemRoot _003CInstance_003Ek__BackingField = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField != null)
			{
				Mdl.Online.Client client = _003CInstance_003Ek__BackingField.Client;
				if ((object)client != null && client.MetaClient == null)
				{
				}
			}
			SystemRoot _003CInstance_003Ek__BackingField2 = SystemRoot.Instance;
			if ((object)_003CInstance_003Ek__BackingField2 != null)
			{
				Mdl.Online.Client client2 = _003CInstance_003Ek__BackingField2.Client;
				if ((object)client2 != null && client2.MetaClient == null)
				{
				}
			}
			List<CustomTimelineCutscene.ItemPrefabMap> list = lockedTools;
			bool flag = default(bool);
			if (flag)
			{
				bool flag2 = default(bool);
				while (!flag2)
				{
				}
				CreateEventHandler();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030D7")]
		[Cpp2IlInjected.Address(RVA = "0x8CB8A0", Offset = "0x8CA2A0", VA = "0x1808CB8A0")]
		public void DisableToolsCutscenes()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = eventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D8")]
		[Cpp2IlInjected.Address(RVA = "0x8CB8A0", Offset = "0x8CA2A0", VA = "0x1808CB8A0")]
		private void DisposeEventHandler()
		{
			ConditionEventHandler conditionEventHandler;
			do
			{
				conditionEventHandler = eventHandler;
			}
			while (conditionEventHandler == null);
			conditionEventHandler.Dispose();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60030D9")]
		[Cpp2IlInjected.Address(RVA = "0x13D9F40", Offset = "0x13D8940", VA = "0x1813D9F40")]
		private void PlayToolUnlockedCutscene(CustomTimelineCutscene.ItemPrefabMap toolData)
		{
			//Discarded unreachable code: IL_003b, IL_005d, IL_007a
			//IL_0012: Expected O, but got I4
			//IL_0055: Expected O, but got I4
			int num = 0;
			CustomTimelineCutscene customTimelineCutscene = unlockToolCutscene;
			int num2 = 0;
			if (customTimelineCutscene != (UnityEngine.Object)num2)
			{
				List<CustomTimelineCutscene.ItemHolder> list = (List<CustomTimelineCutscene.ItemHolder>)(object)new List<T>();
				Dictionary<string, string> dictionary = (Dictionary<string, string>)(object)new Dictionary<TKey, TValue>();
				Dictionary<string, object> dictionary2 = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				LocalizationManager localizationManager = SystemRoot.Instance._localizationManager;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60030DA")]
		[Cpp2IlInjected.Address(RVA = "0x13DA400", Offset = "0x13D8E00", VA = "0x1813DA400")]
		[AsyncStateMachine(typeof(_003CPlayUnlockToolCutscene_003Ed__55))]
		private Task PlayUnlockToolCutscene(GameObject prefabItem, int flagToSet)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x60030DB")]
		[Cpp2IlInjected.Address(RVA = "0x13DAD80", Offset = "0x13D9780", VA = "0x1813DAD80")]
		public Toolbox()
		{
		}
	}
}
