using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Grid;
using Definitions.Items;
using Mdl.Audio;
using Mdl.Avatar;
using Mdl.Characters;
using Mdl.Environments.PointsOfInterest;
using Mdl.Ftue.Cutscenes;
using Mdl.Grid;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mdl.Environments
{
	[Cpp2IlInjected.Token(Token = "0x200063F")]
	public abstract class Environment : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000640")]
		public struct PlaneCullingScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400256B")]
			private readonly Environment environment;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400256C")]
			private readonly List<GameObject> culled;

			[Cpp2IlInjected.Token(Token = "0x6001BE0")]
			[Cpp2IlInjected.Address(RVA = "0x137DE90", Offset = "0x137C890", VA = "0x18137DE90")]
			public PlaneCullingScope(Environment environment, Vector3 position, Plane[] planes, GridLayers layersToHide, [System.Runtime.InteropServices.Optional] HashSet<GameObject> exceptions)
			{
				//IL_0017: Expected O, but got I4
				this.environment = environment;
				float z = position.z;
				int num = 0;
				GridScript gridScript = default(GridScript);
				if (!(gridScript != (UnityEngine.Object)num))
				{
				}
				List<GameObject> list = default(List<GameObject>);
				culled = list;
				throw new NullReferenceException();
			}

			[Cpp2IlInjected.Token(Token = "0x6001BE1")]
			[Cpp2IlInjected.Address(RVA = "0x137DE20", Offset = "0x137C820", VA = "0x18137DE20", Slot = "4")]
			public void Dispose()
			{
				List<GameObject> list = culled;
				if (list != null)
				{
					GridScript.EndPlaneCulling((List<>)(object)list);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000641")]
		public class RaycastCullingScope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400256D")]
			private List<GameObject> culled;

			[Cpp2IlInjected.Token(Token = "0x6001BE2")]
			[Cpp2IlInjected.Address(RVA = "0x137EE20", Offset = "0x137D820", VA = "0x18137EE20")]
			public RaycastCullingScope(Vector3 origin, Vector3 destination, float offset = 0f)
			{
				float z = destination.z;
				float z2 = origin.z;
			}

			[Cpp2IlInjected.Token(Token = "0x6001BE3")]
			[Cpp2IlInjected.Address(RVA = "0x137EA40", Offset = "0x137D440", VA = "0x18137EA40")]
			public unsafe void CullMore(Vector3 origin, Vector3 destination, float offset = 0f)
			{
				//Discarded unreachable code: IL_0085
				RaycastHit[] array = default(RaycastHit[]);
				if ((long)culled == 0 && array.Length != 0)
				{
					List<GameObject> list = (culled = (List<GameObject>)(object)new List<T>());
				}
				int num = 0;
				int length = array.Length;
				if (num < length)
				{
					long num2 = (long)num * 44L;
					int num3 = 0;
					Collider collider = default(Collider);
					if (!collider.gameObject.TryGetComponent<AkAudioListener>(out *(AkAudioListener*)num3))
					{
						Collider collider2 = default(Collider);
						GameObject gameObject = collider2.gameObject;
						int active = 0;
						gameObject.SetActive((byte)active != 0);
						List<GameObject> list2 = culled;
						Collider collider3 = default(Collider);
						GameObject gameObject2 = collider3.gameObject;
						((List<T>)(object)list2).Add((T)gameObject2);
					}
					num++;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6001BE4")]
			[Cpp2IlInjected.Address(RVA = "0x137E9E0", Offset = "0x137D3E0", VA = "0x18137E9E0")]
			private bool CanCullMore(GameObject obj)
			{
				//Discarded unreachable code: IL_0005
				bool flag = default(bool);
				return !flag;
			}

			[Cpp2IlInjected.Token(Token = "0x6001BE5")]
			[Cpp2IlInjected.Address(RVA = "0x137EDB0", Offset = "0x137D7B0", VA = "0x18137EDB0", Slot = "4")]
			public void Dispose()
			{
				List<GameObject> list = culled;
				if (list != null)
				{
					GridScript.EndPlaneCulling((List<>)(object)list);
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002559")]
		public Transform SpawnPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400255A")]
		public ReflectionProbe[] reflectionProbes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400255B")]
		public Transform WaterSurface;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400255C")]
		public bool CanGarden = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400255D")]
		public bool AllowPhotoToolFreeCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400255E")]
		[Header("Audio")]
		public bool useVillageRain;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400255F")]
		public AudioManager.Location AudioLocation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4002560")]
		public State IP_State;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4002561")]
		public AK.Wwise.Event sfxAmbient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4002562")]
		public Switch defaultFootStepSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400256A")]
		private GameObject[] gridObjectLayersObjects;

		[Cpp2IlInjected.Token(Token = "0x170003E7")]
		public IPointOfInterest[] PointsOfInterest
		{
			[Cpp2IlInjected.Token(Token = "0x6001BBE")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			[CompilerGenerated]
			get
			{
				return _003CPointsOfInterest_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BBF")]
			[Cpp2IlInjected.Address(RVA = "0x8E8E50", Offset = "0x8E7850", VA = "0x1808E8E50")]
			[CompilerGenerated]
			protected set
			{
				_003CPointsOfInterest_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = new IPointOfInterest[0];


		[Cpp2IlInjected.Token(Token = "0x170003E8")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x58"), Cpp2IlInjected.Token(Token = "0x4002564")]
		public bool HasBeenEntered
		{
			[Cpp2IlInjected.Token(Token = "0x6001BC0")]
			[Cpp2IlInjected.Address(RVA = "0xA5F820", Offset = "0xA5E220", VA = "0x180A5F820")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001BC1")]
			[Cpp2IlInjected.Address(RVA = "0xE3A650", Offset = "0xE39050", VA = "0x180E3A650")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x170003E9")]
		public CancellationTokenProvider CancellationTokenProvider
		{
			[Cpp2IlInjected.Token(Token = "0x6001BC2")]
			[Cpp2IlInjected.Address(RVA = "0x5AC060", Offset = "0x5AAA60", VA = "0x1805AC060")]
			[CompilerGenerated]
			get
			{
				return _003CCancellationTokenProvider_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BC3")]
			[Cpp2IlInjected.Address(RVA = "0x725350", Offset = "0x723D50", VA = "0x180725350")]
			[CompilerGenerated]
			private set
			{
				_003CCancellationTokenProvider_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EA")]
		public GridCollection GridCollection
		{
			[Cpp2IlInjected.Token(Token = "0x6001BC4")]
			[Cpp2IlInjected.Address(RVA = "0x63F630", Offset = "0x63E030", VA = "0x18063F630")]
			[CompilerGenerated]
			get
			{
				return _003CGridCollection_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BC5")]
			[Cpp2IlInjected.Address(RVA = "0x63FA50", Offset = "0x63E450", VA = "0x18063FA50")]
			[CompilerGenerated]
			private set
			{
				_003CGridCollection_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003EB")]
		public virtual IEnumerable<GridScript> GridScriptsList
		{
			[Cpp2IlInjected.Token(Token = "0x6001BC6")]
			[Cpp2IlInjected.Address(RVA = "0x19DD750", Offset = "0x19DC150", VA = "0x1819DD750", Slot = "4")]
			[IteratorStateMachine(typeof(_003Cget_GridScriptsList_003Ed__27))]
			get
			{
				new _003Cget_GridScriptsList_003Ed__27(-2)._003C_003E4__this = this;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003E")]
		public event EventHandler EnvironmentEnteredEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001BC7")]
			[Cpp2IlInjected.Address(RVA = "0x19DD6B0", Offset = "0x19DC0B0", VA = "0x1819DD6B0")]
			[CompilerGenerated]
			add
			{
				EventHandler environmentEnteredEvent = this.EnvironmentEnteredEvent;
				Delegate @delegate = Delegate.Combine(environmentEnteredEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != environmentEnteredEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001BC8")]
			[Cpp2IlInjected.Address(RVA = "0x19DD940", Offset = "0x19DC340", VA = "0x1819DD940")]
			[CompilerGenerated]
			remove
			{
				EventHandler environmentEnteredEvent = this.EnvironmentEnteredEvent;
				Delegate @delegate = Delegate.Remove(environmentEnteredEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != environmentEnteredEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400003F")]
		public static event EventHandler AnyEnvironmentEnteredEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001BC9")]
			[Cpp2IlInjected.Address(RVA = "0x19DD530", Offset = "0x19DBF30", VA = "0x1819DD530")]
			[CompilerGenerated]
			add
			{
				EventHandler anyEnvironmentEnteredEvent = Environment.AnyEnvironmentEnteredEvent;
				Delegate @delegate = Delegate.Combine(anyEnvironmentEnteredEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(Environment).TypeHandle != anyEnvironmentEnteredEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001BCA")]
			[Cpp2IlInjected.Address(RVA = "0x19DD7C0", Offset = "0x19DC1C0", VA = "0x1819DD7C0")]
			[CompilerGenerated]
			remove
			{
				EventHandler anyEnvironmentEnteredEvent = Environment.AnyEnvironmentEnteredEvent;
				Delegate @delegate = Delegate.Remove(anyEnvironmentEnteredEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(Environment).TypeHandle != anyEnvironmentEnteredEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000040")]
		public static event Action<bool> AnyEnvironmentLoadingStateChangeEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6001BCB")]
			[Cpp2IlInjected.Address(RVA = "0x19DD5F0", Offset = "0x19DBFF0", VA = "0x1819DD5F0")]
			[CompilerGenerated]
			add
			{
				Action<bool> anyEnvironmentLoadingStateChangeEvent = Environment.AnyEnvironmentLoadingStateChangeEvent;
				Delegate @delegate = Delegate.Combine(anyEnvironmentLoadingStateChangeEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(Environment).TypeHandle != anyEnvironmentLoadingStateChangeEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6001BCC")]
			[Cpp2IlInjected.Address(RVA = "0x19DD880", Offset = "0x19DC280", VA = "0x1819DD880")]
			[CompilerGenerated]
			remove
			{
				Action<bool> anyEnvironmentLoadingStateChangeEvent = Environment.AnyEnvironmentLoadingStateChangeEvent;
				Delegate @delegate = Delegate.Remove(anyEnvironmentLoadingStateChangeEvent, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)typeof(Environment).TypeHandle != anyEnvironmentLoadingStateChangeEvent)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BCD")]
		[Cpp2IlInjected.Address(RVA = "0x19DCED0", Offset = "0x19DB8D0", VA = "0x1819DCED0")]
		public static void RaiseAnyEnvironmentLoadingStateChange(bool isLoading)
		{
			//IL_0011: Expected O, but got I4
			((Action<T>)(object)Environment.AnyEnvironmentLoadingStateChangeEvent)?.Invoke((T)isLoading);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BCE")]
		[Cpp2IlInjected.Address(RVA = "0x19DD0E0", Offset = "0x19DBAE0", VA = "0x1819DD0E0")]
		private void Start()
		{
			CancellationTokenProvider cancellationTokenProvider = (CancellationTokenProvider = base.gameObject.GetOrAddComponent<CancellationTokenProvider>());
			int[] array = new int[2];
			int num = (array[0] = LayerMask.NameToLayer("GridObjects"));
			int num2 = (array[0] = LayerMask.NameToLayer("NonBlockingGridObjects"));
			int[] layers = array;
			GameObject[] array2 = UnityEngine.Object.FindObjectsOfType<GameObject>();
			Func<GameObject, bool> func = (Func<GameObject, bool>)(object)(Func<T, TResult>)delegate(GameObject x)
			{
				//Discarded unreachable code: IL_0035
				Scene scene = x.scene;
				Environment environment = this;
				int handle = scene.m_Handle;
				if ((object)environment.gameObject.scene == null)
				{
				}
				int[] array4 = layers;
				int layer = x.layer;
				bool result = default(bool);
				return result;
			};
			GameObject[] array3 = (gridObjectLayersObjects = Enumerable.Where<GameObject>((IEnumerable<>)(object)array2, (Func<, >)(object)func).ToArray<GameObject>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BCF")]
		[Cpp2IlInjected.Address(RVA = "0x19DC760", Offset = "0x19DB160", VA = "0x1819DC760", Slot = "5")]
		[AsyncStateMachine(typeof(_003CEnterEnvironment_003Ed__40))]
		internal virtual Task EnterEnvironment(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD0")]
		[Cpp2IlInjected.Address(RVA = "0x19DD320", Offset = "0x19DBD20", VA = "0x1819DD320")]
		private void TrySetAudio()
		{
			//Discarded unreachable code: IL_0044
			int num = 0;
			if (CutsceneSystem.SceneIntroCutsceneNeedsToPlay())
			{
				SystemRoot.Instance.GetSystem<AudioManager>().SetStateToNone();
				AudioManager.OnCutsceneAudioPop -= OnCutsceneAudioDone;
				AudioManager.OnCutsceneAudioPop += OnCutsceneAudioDone;
			}
			else
			{
				IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD1")]
		[Cpp2IlInjected.Address(RVA = "0x19DCCE0", Offset = "0x19DB6E0", VA = "0x1819DCCE0")]
		private void OnCutsceneAudioDone(Cutscene cutscene)
		{
			AudioManager.OnCutsceneAudioPop -= OnCutsceneAudioDone;
			IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal> elementIdentifiers = (IEnumerable<Rewired.Interfaces.IControllerElementIdentifierCommon_Internal>)((Rewired.Data.Mapping.IHardwareControllerMap_Internal)this).get_ElementIdentifiers();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD2")]
		[Cpp2IlInjected.Address(RVA = "0x19DCFD0", Offset = "0x19DB9D0", VA = "0x1819DCFD0", Slot = "6")]
		protected virtual void SetAudioEnvironment()
		{
			//Discarded unreachable code: IL_003f
			IP_State.SetValue();
			AudioManager system = SystemRoot.Instance.GetSystem<AudioManager>();
			bool flag = useVillageRain;
			Switch @switch = defaultFootStepSwitch;
			AK.Wwise.Event @event = sfxAmbient;
			AudioManager.Location audioLocation = AudioLocation;
			system.SetEnviromentAudio(audioLocation, @event, @switch, flag);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD3")]
		[Cpp2IlInjected.Address(RVA = "0x19DC8E0", Offset = "0x19DB2E0", VA = "0x1819DC8E0", Slot = "7")]
		internal virtual Task ExitEnvironment(Profile profile, PlayerAvatar avatar, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0017
			SystemRoot.Instance.GetSystem<AudioManager>().PopLocation();
			int num = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD4")]
		[Cpp2IlInjected.Address(RVA = "0x19DCAE0", Offset = "0x19DB4E0", VA = "0x1819DCAE0", Slot = "8")]
		protected virtual Task Init(Profile profile, GridCollection gridCollection, BaseEnvironmentDoor door, PlayerAvatar avatar, CancellationToken ct)
		{
			//Discarded unreachable code: IL_0047
			//IL_0017: Expected O, but got I4
			GridCollection = gridCollection;
			Transform spawnPosition = SpawnPosition;
			int num = 0;
			if (spawnPosition != (UnityEngine.Object)num)
			{
				Transform spawnPosition2 = SpawnPosition;
				PlayerNavigation system = SystemRoot.Instance.GetSystem<PlayerNavigation>();
				Transform spawnPosition3 = SpawnPosition;
				Vector3 vector = default(Vector3);
				float z = vector.z;
			}
			int num2 = 0;
			return Task.CompletedTask;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD5")]
		[Cpp2IlInjected.Address(RVA = "0x52D7C0", Offset = "0x52C1C0", VA = "0x18052D7C0", Slot = "9")]
		public virtual bool ShouldSpawnCharacter(Item characterItem)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "10")]
		public virtual void SpawnCharacter(Mdl.Characters.Character character)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD7")]
		[Cpp2IlInjected.Address(RVA = "0x19DCF40", Offset = "0x19DB940", VA = "0x1819DCF40", Slot = "11")]
		public virtual void RefreshGrid()
		{
			IPointOfInterest[] array = (PointsOfInterest = GetComponentsInChildren<IPointOfInterest>());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD8")]
		[Cpp2IlInjected.Address(RVA = "0x19DCAA0", Offset = "0x19DB4A0", VA = "0x1819DCAA0")]
		public GridScript GetCurrentGrid(Vector3 position)
		{
			float z = position.z;
			GridScript result = default(GridScript);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BD9")]
		[Cpp2IlInjected.Address(RVA = "0x19DC9E0", Offset = "0x19DB3E0", VA = "0x1819DC9E0", Slot = "12")]
		public virtual GridScript GetCurrentGrid(Vector3 position, out bool voidGrid)
		{
			//IL_0010: Expected O, but got I4
			GridScript component = GetComponent<GridScript>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num) && component.GridData != null)
			{
				return component;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BDA")]
		[Cpp2IlInjected.Address(RVA = "0x19DC2E0", Offset = "0x19DACE0", VA = "0x1819DC2E0")]
		private void BeginPlaneCulling(Plane[] planes, [System.Runtime.InteropServices.Optional] HashSet<GameObject> exceptions)
		{
			//Discarded unreachable code: IL_008a
			//IL_003e: Expected O, but got I4
			GameObject[] array = gridObjectLayersObjects;
			int num = 0;
			if (num >= array.Length)
			{
				return;
			}
			GameObject gridObjectLayerGO = array[num];
			GameObject gameObject = gridObjectLayerGO;
			int num2 = 0;
			if (gameObject != (UnityEngine.Object)num2)
			{
				if (exceptions != null)
				{
					GameObject item = gridObjectLayerGO;
					if (((HashSet<T>)(object)exceptions).Contains((T)item))
					{
						goto IL_0085;
					}
				}
				Func<Plane, bool> func = (Func<Plane, bool>)(object)(Func<T, TResult>)delegate
				{
					//Discarded unreachable code: IL_0018
					Transform transform = gridObjectLayerGO.transform;
					Vector3 vector = default(Vector3);
					float z = vector.z;
					bool flag = default(bool);
					return !flag;
				};
				if (((IEnumerable<>)(object)planes).All<Plane>((Func<, >)(object)func))
				{
					GameObject gameObject2 = gridObjectLayerGO;
					int active = 0;
					gameObject2.SetActive((byte)active != 0);
				}
			}
			goto IL_0085;
			IL_0085:
			num++;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BDB")]
		[Cpp2IlInjected.Address(RVA = "0x19DC4B0", Offset = "0x19DAEB0", VA = "0x1819DC4B0")]
		private void EndPlaneCulling()
		{
			//Discarded unreachable code: IL_005c, IL_0062, IL_0068
			int num = 0;
			GameObject[] array = gridObjectLayersObjects;
			Func<GameObject, bool> _003C_003E9__52_ = _003C_003Ec._003C_003E9__52_0;
			if (_003C_003E9__52_ == null)
			{
				_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)delegate(GameObject x)
				{
					//IL_0009: Expected O, but got I4
					int num4 = 0;
					return x != (UnityEngine.Object)num4;
				};
			}
			IEnumerable<GameObject> enumerable = (IEnumerable<GameObject>)Enumerable.Where<GameObject>((IEnumerable<>)(object)array, (Func<, >)(object)_003C_003E9__52_);
			if (enumerable != null)
			{
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					if (num == (int)num2)
					{
						goto IL_0050;
					}
					num++;
				}
				bool flag = default(bool);
				if (flag)
				{
					bool flag2 = default(bool);
					while (!flag2)
					{
					}
				}
				goto IL_0050;
			}
			goto IL_0057;
			IL_0057:
			if (enumerable == null)
			{
			}
			return;
			IL_0050:
			ulong num3 = num3 + num3;
			goto IL_0057;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BDC")]
		[Cpp2IlInjected.Address(RVA = "0x19DCD90", Offset = "0x19DB790", VA = "0x1819DCD90")]
		public PlaneCullingScope PlaneCulling(Vector3 position, Plane plane, GridLayers layersToHide, [System.Runtime.InteropServices.Optional] HashSet<GameObject> exceptions)
		{
			Plane[] array = new Plane[1];
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BDD")]
		[Cpp2IlInjected.Address(RVA = "0x19DCE70", Offset = "0x19DB870", VA = "0x1819DCE70")]
		public PlaneCullingScope PlaneCulling(Vector3 position, Plane[] planes, GridLayers layersToHide, [System.Runtime.InteropServices.Optional] HashSet<GameObject> exceptions)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BDE")]
		[Cpp2IlInjected.Address(RVA = "0x19DCF90", Offset = "0x19DB990", VA = "0x1819DCF90")]
		[RuntimeInitializeOnLoadMethod]
		public static void ResetAnyEnvironmentEnteredEvent()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001BDF")]
		[Cpp2IlInjected.Address(RVA = "0x19DD4D0", Offset = "0x19DBED0", VA = "0x1819DD4D0")]
		protected Environment()
		{
		}
	}
}
