using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Decals;
using Mdl.Environments;
using Mdl.Graphic;
using Mdl.Grid;
using Mdl.Items;
using Mdl.Navigation;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using Meta.Customization;
using UnityEngine;

namespace Mdl.Furnitures
{
	[Cpp2IlInjected.Token(Token = "0x2000545")]
	public class FurnitureAppearance : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000546")]
		private struct LoadedFurniture
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40020D1")]
			public FurnitureItem item;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40020D2")]
			public GameObject asset;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40020C3")]
		public ProjectorResolution resolution = ProjectorResolution.R512;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40020C4")]
		public DecalRenderingTool decalRenderingTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40020C5")]
		public List<FurnitureItemType> allowDecals = (List<FurnitureItemType>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40020C6")]
		public Transform customizationStartCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40020C7")]
		public OrbitCameraTarget orbitCameraTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40020C9")]
		public FurnitureHolder holder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40020CA")]
		private IFurniture _originalFurniture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40020CB")]
		private Profile _currentProfile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40020CC")]
		private Coroutine _loadingCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40020CD")]
		private CancellationTokenSource _loadingCtSource = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40020CE")]
		private CancellationTokenSource _updateDecalsCtSource = new CancellationTokenSource();

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40020CF")]
		private List<FurnitureItemScript> _currentObjectsWithDecals = (List<FurnitureItemScript>)(object)new List<T>();

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40020D0")]
		private Dictionary<int, LoadedFurniture> _loadedFurniture = (Dictionary<int, LoadedFurniture>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x17000327")]
		public FurnitureWorkingCopy CurrentFurniture
		{
			[Cpp2IlInjected.Token(Token = "0x6001786")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CCurrentFurniture_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001787")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			private set
			{
				_003CCurrentFurniture_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001775")]
		[Cpp2IlInjected.Address(RVA = "0x8B6200", Offset = "0x8B4C00", VA = "0x1808B6200")]
		public bool IsCustomizable(bool force)
		{
			if ((long)CurrentFurniture != 0)
			{
				FurnitureWorkingCopy furnitureWorkingCopy = CurrentFurniture;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = furnitureWorkingCopy.Item;
				FurnitureItemData furnitureItemData = default(FurnitureItemData);
				if (furnitureItemData != null)
				{
					List<MeshRenderer> _003CRenderers_003Ek__BackingField = holder.Renderers;
					return true;
				}
			}
			if ((long)CurrentFurniture != 0)
			{
				FurnitureWorkingCopy furnitureWorkingCopy2 = CurrentFurniture;
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				Item item2 = furnitureWorkingCopy2.Item;
				FurnitureItemData furnitureItemData2 = default(FurnitureItemData);
				if (furnitureItemData2 != null)
				{
					List<MeshRenderer> _003CRenderers_003Ek__BackingField2 = holder.Renderers;
					FurnitureWorkingCopy furnitureWorkingCopy3 = CurrentFurniture;
					List<FurnitureItemType> list = allowDecals;
					FurnitureItem furnitureItem = furnitureWorkingCopy3.FurnitureItem;
					bool result = default(bool);
					return result;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001776")]
		[Cpp2IlInjected.Address(RVA = "0x8B5660", Offset = "0x8B4060", VA = "0x1808B5660")]
		public bool CanEditColor(bool force)
		{
			if ((long)CurrentFurniture != 0)
			{
				FurnitureWorkingCopy furnitureWorkingCopy = CurrentFurniture;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = furnitureWorkingCopy.Item;
				FurnitureItemData furnitureItemData = default(FurnitureItemData);
				if (furnitureItemData == null)
				{
					int num = 0;
				}
				List<MeshRenderer> _003CRenderers_003Ek__BackingField = holder.Renderers;
				bool result = default(bool);
				return result;
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001777")]
		[Cpp2IlInjected.Address(RVA = "0x8B57B0", Offset = "0x8B41B0", VA = "0x1808B57B0")]
		public bool CanEditDecals(bool force)
		{
			if ((long)CurrentFurniture != 0)
			{
				FurnitureWorkingCopy furnitureWorkingCopy = CurrentFurniture;
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				Item item = furnitureWorkingCopy.Item;
				FurnitureItemData furnitureItemData = default(FurnitureItemData);
				if (furnitureItemData != null)
				{
					List<MeshRenderer> _003CRenderers_003Ek__BackingField = holder.Renderers;
					FurnitureWorkingCopy furnitureWorkingCopy2 = CurrentFurniture;
					List<FurnitureItemType> list = allowDecals;
					FurnitureItem furnitureItem = furnitureWorkingCopy2.FurnitureItem;
					bool result = default(bool);
					return result;
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001778")]
		[Cpp2IlInjected.Address(RVA = "0x8B5F80", Offset = "0x8B4980", VA = "0x1808B5F80")]
		public bool HasDecals(int furnitureItem, GameObject asset)
		{
			//IL_0010: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			//IL_0057: Expected O, but got I4
			//IL_0075: Expected O, but got I4
			//IL_0080: Expected O, but got I4
			FurnitureItemScript component = asset.GetComponent<FurnitureItemScript>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				TextAsset staticDecals = component.staticDecals;
				int num2 = 0;
				if (staticDecals != (UnityEngine.Object)num2)
				{
					return true;
				}
			}
			if (((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureData_).ContainsKey((TKey)furnitureItem) && ((Furniture)((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureData_)[(TKey)furnitureItem]).currentDesign_ != -1)
			{
				Design design = (Design)((MapField<TKey, TValue>)(object)((DesignMap)((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureDesigns_)[(TKey)furnitureItem]).designs_)[(TKey)furnitureItem];
				if (design != null)
				{
					return (long)(IntPtr)design > 0L;
				}
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001779")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B00", Offset = "0x8B4500", VA = "0x1808B5B00")]
		public List<KeyValuePair<int, Design>> GetAllDesigns(int furnitureItem)
		{
			//IL_0016: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			if (((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureDesigns_).ContainsKey((TKey)furnitureItem))
			{
				return (List<KeyValuePair<int, Design>>)(object)Enumerable.ToList<KeyValuePair<int, Design>>((IEnumerable<>)(object)((DesignMap)((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureDesigns_)[(TKey)furnitureItem]).designs_);
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600177A")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BE0", Offset = "0x8B45E0", VA = "0x1808B5BE0")]
		public int GetCurrentDesignId()
		{
			return CurrentFurniture?.CurrentDesign() ?? (-1);
		}

		[Cpp2IlInjected.Token(Token = "0x600177B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5C00", Offset = "0x8B4600", VA = "0x1808B5C00")]
		public int GetCurrentDesignId(int furnitureItem)
		{
			//Discarded unreachable code: IL_0037
			//IL_0016: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			if (((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureData_).ContainsKey((TKey)furnitureItem))
			{
				return ((Furniture)((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureData_)[(TKey)furnitureItem]).currentDesign_;
			}
			return -1;
		}

		[Cpp2IlInjected.Token(Token = "0x600177C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5E20", Offset = "0x8B4820", VA = "0x1808B5E20")]
		public IDesign GetCurrentDesign(int furnitureItem)
		{
			//IL_0016: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			//IL_0058: Expected O, but got I4
			if (((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureData_).ContainsKey((TKey)furnitureItem) && ((Furniture)((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureData_)[(TKey)furnitureItem]).currentDesign_ != -1)
			{
				Design design = (Design)((MapField<TKey, TValue>)(object)((DesignMap)((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureDesigns_)[(TKey)furnitureItem]).designs_)[(TKey)furnitureItem];
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600177D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D50", Offset = "0x8B4750", VA = "0x1808B5D50")]
		public IDesign GetCurrentDesign()
		{
			//IL_0047: Expected O, but got I4
			//IL_005a: Expected O, but got I4
			FurnitureWorkingCopy furnitureWorkingCopy = CurrentFurniture;
			if (furnitureWorkingCopy != null)
			{
				int num = furnitureWorkingCopy.CurrentDesign();
				if (num != -1)
				{
					ProfilePlayer player_ = _currentProfile.player_;
					Furniture _003CData_003Ek__BackingField = CurrentFurniture.Data;
					MapField<int, DesignMap> furnitureDesigns_ = player_.furnitureDesigns_;
					int furnitureItem_ = _003CData_003Ek__BackingField.furnitureItem_;
					MapField<int, Design> designs_ = ((DesignMap)((MapField<TKey, TValue>)(object)furnitureDesigns_)[(TKey)furnitureItem_]).designs_;
					furnitureItem_ = num;
					Design design = (Design)((MapField<TKey, TValue>)(object)designs_)[(TKey)furnitureItem_];
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600177E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5CC0", Offset = "0x8B46C0", VA = "0x1808B5CC0")]
		public DesignWorkingCopy GetCurrentDesignWorkingCopy()
		{
			IDesign currentDesign = GetCurrentDesign();
			if (currentDesign == null)
			{
				return new DesignWorkingCopy();
			}
			return new DesignWorkingCopy(currentDesign);
		}

		[Cpp2IlInjected.Token(Token = "0x600177F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7940", Offset = "0x8B6340", VA = "0x1808B7940")]
		public void UpdateBaseColor()
		{
			//IL_001d: Expected O, but got I4
			int num = 0;
			IDesign currentDesign = GetCurrentDesign();
			if (currentDesign != null && currentDesign == null)
			{
				holder.SetTint((Color)num);
				return;
			}
			Color _003CDefaultTint_003Ek__BackingField = holder.DefaultTint;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001780")]
		[Cpp2IlInjected.Address(RVA = "0x8B5600", Offset = "0x8B4000", VA = "0x1808B5600")]
		public void ApplyBaseColor(Color color)
		{
			//Discarded unreachable code: IL_0008
			FurnitureHolder furnitureHolder = holder;
		}

		[Cpp2IlInjected.Token(Token = "0x6001781")]
		[Cpp2IlInjected.Address(RVA = "0x8B5630", Offset = "0x8B4030", VA = "0x1808B5630")]
		public void ApplyDefaultBaseColor()
		{
			//Discarded unreachable code: IL_0016
			FurnitureHolder furnitureHolder = holder;
			Color _003CDefaultTint_003Ek__BackingField = furnitureHolder.DefaultTint;
			furnitureHolder.SetTint(_003CDefaultTint_003Ek__BackingField);
		}

		[Cpp2IlInjected.Token(Token = "0x6001782")]
		[Cpp2IlInjected.Address(RVA = "0x8B7A10", Offset = "0x8B6410", VA = "0x1808B7A10")]
		[IteratorStateMachine(typeof(_003CUpdateDesign_003Ed__16))]
		public IEnumerator UpdateDesign()
		{
			int _003C_003E1__state = default(int);
			_003CUpdateDesign_003Ed__16 _003CUpdateDesign_003Ed__ = new _003CUpdateDesign_003Ed__16(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CUpdateDesign_003Ed__._003C_003E4__this = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001783")]
		[Cpp2IlInjected.Address(RVA = "0x8B7270", Offset = "0x8B5C70", VA = "0x1808B7270")]
		[AsyncStateMachine(typeof(_003CSetFurnitureDesign_003Ed__17))]
		public Task<Meta.FurnitureCustomization.Types.Response> SetFurnitureDesign(FurnitureItem furnitureItem, int designId, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<Meta.FurnitureCustomization.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001784")]
		[Cpp2IlInjected.Address(RVA = "0x8B6F60", Offset = "0x8B5960", VA = "0x1808B6F60")]
		[AsyncStateMachine(typeof(_003CSaveFurnitureDesign_003Ed__18))]
		public Task<SaveFurnitureDesign.Types.Response> SaveFurnitureDesign(FurnitureItem furnitureItem, DesignWorkingCopy design, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<SaveFurnitureDesign.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001785")]
		[Cpp2IlInjected.Address(RVA = "0x8B59A0", Offset = "0x8B43A0", VA = "0x1808B59A0")]
		[AsyncStateMachine(typeof(_003CDeleteFurnitureDesign_003Ed__19))]
		public Task<DeleteFurnitureDesign.Types.Response> DeleteFurnitureDesign(FurnitureItem furnitureItem, int designId, CancellationToken ct)
		{
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			int num = 0;
			Task<> result = default(Task<>);
			return (Task<DeleteFurnitureDesign.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001788")]
		[Cpp2IlInjected.Address(RVA = "0x8B7550", Offset = "0x8B5F50", VA = "0x1808B7550")]
		private void Start()
		{
			GridEditMode.OnObjectAdded += OnObjectAdded;
			GridEditMode.OnObjectRemoved += OnObjectRemoved;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent += OnCurrentSceneChanged;
			FurnitureHolder furnitureHolder = holder;
			ProjectorResolution projectorResolution = resolution;
			int texturePoolMaxCount = furnitureHolder.texturePoolMaxCount;
			int format = default(int);
			int textureSize = default(int);
			TexturePool _003CDecalsTextures_003Ek__BackingField = new TexturePool(textureSize, texturePoolMaxCount, (RenderTextureFormat)format);
			format = 0;
			textureSize = (int)projectorResolution;
			furnitureHolder.DecalsTextures = _003CDecalsTextures_003Ek__BackingField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001789")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5090", VA = "0x1808B6690")]
		private void OnDestroy()
		{
			UnloadAllFurniture();
			GridEditMode.OnObjectAdded -= OnObjectAdded;
			GridEditMode.OnObjectRemoved -= OnObjectRemoved;
			Mdl.Environments.Environment.AnyEnvironmentEnteredEvent -= OnCurrentSceneChanged;
		}

		[Cpp2IlInjected.Token(Token = "0x600178A")]
		[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
		public void Init(Profile profile)
		{
			_currentProfile = profile;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600178B")]
		[Cpp2IlInjected.Address(RVA = "0x8B64D0", Offset = "0x8B4ED0", VA = "0x1808B64D0")]
		public void LoadCurrent(bool designOnly = false)
		{
			//IL_002d: Expected O, but got I8
			if ((long)_loadingCoroutine != 0)
			{
				_loadingCtSource.Cancel();
				Coroutine loadingCoroutine = _loadingCoroutine;
				StopCoroutine(loadingCoroutine);
				_loadingCoroutine = (Coroutine)0;
			}
			CancellationTokenSource cancellationTokenSource = (_loadingCtSource = new CancellationTokenSource());
			int _003C_003E1__state = default(int);
			_003CLoadingCoroutine_003Ed__39 _003CLoadingCoroutine_003Ed__ = new _003CLoadingCoroutine_003Ed__39(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CLoadingCoroutine_003Ed__._003C_003E4__this = this;
			_003CLoadingCoroutine_003Ed__.designOnly = designOnly;
			Coroutine coroutine = (_loadingCoroutine = StartCoroutine(_003CLoadingCoroutine_003Ed__));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600178C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6600", Offset = "0x8B5000", VA = "0x1808B6600")]
		[IteratorStateMachine(typeof(_003CLoadingCoroutine_003Ed__39))]
		private IEnumerator LoadingCoroutine(bool designOnly)
		{
			int _003C_003E1__state = default(int);
			_003CLoadingCoroutine_003Ed__39 _003CLoadingCoroutine_003Ed__ = new _003CLoadingCoroutine_003Ed__39(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CLoadingCoroutine_003Ed__._003C_003E4__this = this;
			_003CLoadingCoroutine_003Ed__.designOnly = designOnly;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600178D")]
		[Cpp2IlInjected.Address(RVA = "0x8B70D0", Offset = "0x8B5AD0", VA = "0x1808B70D0")]
		public void SelectFurniture(FurnitureItem furnitureItem)
		{
			//Discarded unreachable code: IL_0092
			//IL_001d: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			//IL_0069: Expected I4, but got I8
			int itemID;
			Item item = default(Item);
			do
			{
				itemID = item.ItemID;
				if (((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureData_).ContainsKey((TKey)itemID))
				{
					Furniture furniture = (Furniture)((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureData_)[(TKey)itemID];
				}
				int num = 0;
				_originalFurniture = (IFurniture)num;
			}
			while (_originalFurniture != null);
			Furniture furniture2 = new Furniture();
			furniture2.furnitureItem_ = itemID;
			furniture2.currentDesign_ = -1;
			_originalFurniture = furniture2;
			FurnitureWorkingCopy furnitureWorkingCopy = (CurrentFurniture = new FurnitureWorkingCopy(_originalFurniture));
			int designOnly = 0;
			LoadCurrent((byte)designOnly != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600178E")]
		[Cpp2IlInjected.Address(RVA = "0x8B67A0", Offset = "0x8B51A0", VA = "0x1808B67A0")]
		private void OnObjectAdded(GameObject instance)
		{
			//Discarded unreachable code: IL_004f
			//IL_0010: Expected O, but got I4
			//IL_003f: Expected I4, but got O
			FurnitureItemScript component = instance.GetComponent<FurnitureItemScript>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				int itemID = component.ItemID;
				if (HasDecals(itemID, instance) && !((List<T>)(object)_currentObjectsWithDecals).Contains((T)component))
				{
					List<FurnitureItemScript> list = (List<FurnitureItemScript>)(object)new List<T>((int)_currentObjectsWithDecals);
					((List<T>)(object)list).Add((T)component);
					this.UpdateInstances((IEnumerable<>)list);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600178F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6910", Offset = "0x8B5310", VA = "0x1808B6910")]
		private void OnObjectRemoved(GameObject instance)
		{
			//Discarded unreachable code: IL_003e
			//IL_0010: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			FurnitureItemScript component = instance.GetComponent<FurnitureItemScript>();
			int num = 0;
			if (component != (UnityEngine.Object)num && ((List<T>)(object)_currentObjectsWithDecals).Contains((T)component))
			{
				List<FurnitureItemScript> list = (List<FurnitureItemScript>)(object)new List<T>((int)_currentObjectsWithDecals);
				bool flag = ((List<T>)(object)list).Remove((T)component);
				this.UpdateInstances((IEnumerable<>)list);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001790")]
		[Cpp2IlInjected.Address(RVA = "0x8B6680", Offset = "0x8B5080", VA = "0x1808B6680")]
		private void OnCurrentSceneChanged(object sender, EventArgs e)
		{
			Profile currentProfile = _currentProfile;
			RefreshAllDecals(currentProfile);
		}

		[Cpp2IlInjected.Token(Token = "0x6001791")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A50", Offset = "0x8B5450", VA = "0x1808B6A50")]
		public void RefreshAllDecals(Profile profile)
		{
			//Discarded unreachable code: IL_0037
			_currentProfile = profile;
			SceneStack sceneStack = SystemRoot.Instance._sceneStack;
			SceneData sceneData = default(SceneData);
			AsyncOperation operation = sceneData.sceneInstance.m_Operation;
			CameraNavigationConfig editCameraConfig = sceneData.EditCameraConfig;
			GameObject gameObject = default(GameObject);
			FurnitureItemScript[] componentsInChildren = gameObject.GetComponentsInChildren<FurnitureItemScript>();
			this.UpdateInstances((IEnumerable<>)(object)componentsInChildren);
		}

		[Cpp2IlInjected.Token(Token = "0x6001792")]
		[Cpp2IlInjected.Address(RVA = "0x8B7BB0", Offset = "0x8B65B0", VA = "0x1808B7BB0")]
		private void UpdateInstances(IEnumerable<FurnitureItemScript> furnitures)
		{
			//Discarded unreachable code: IL_0039
			_updateDecalsCtSource.Cancel();
			CancellationTokenSource cancellationTokenSource = (_updateDecalsCtSource = new CancellationTokenSource());
			CancellationToken token = _updateDecalsCtSource.Token;
			int num = 0;
			Task task = default(Task);
			IEnumerator routine = task.AsIEnumerator();
			Coroutine coroutine = StartCoroutine(routine);
		}

		[Cpp2IlInjected.Token(Token = "0x6001793")]
		[Cpp2IlInjected.Address(RVA = "0x8B7A80", Offset = "0x8B6480", VA = "0x1808B7A80")]
		[AsyncStateMachine(typeof(_003CUpdateInstancesAsync_003Ed__46))]
		private Task UpdateInstancesAsync(IEnumerable<FurnitureItemScript> furnitures, CancellationToken ct)
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001794")]
		[Cpp2IlInjected.Address(RVA = "0x8B6B90", Offset = "0x8B5590", VA = "0x1808B6B90")]
		private void ReleaseUnusedTextures(IEnumerable<FurnitureItemScript> furnitures)
		{
			//Discarded unreachable code: IL_0077, IL_007d, IL_0083, IL_0089, IL_008f, IL_0095
			//IL_0044: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			List<int> assignedIds;
			uint num4 = default(uint);
			ItemScript itemScript = default(ItemScript);
			GameObject asset = default(GameObject);
			int num6 = default(int);
			while (true)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				((List<T>)(object)_currentObjectsWithDecals).Clear();
				assignedIds = (List<int>)(object)holder.DecalsTextures.GetAssignedIds();
				if (assignedIds == null)
				{
					break;
				}
				if (num3 < (int)num4)
				{
					num3 += num3;
					if (num3 == (int)num4)
					{
						goto IL_0066;
					}
					num3++;
				}
				int num5 = 0;
				if (itemScript == (UnityEngine.Object)num5 || !HasDecals(num6, asset))
				{
					continue;
				}
				List<FurnitureItemScript> currentObjectsWithDecals = _currentObjectsWithDecals;
				bool flag = ((List<T>)(object)assignedIds).Remove((T)num6);
				goto IL_0066;
				IL_0066:
				num6 += num6;
				break;
			}
			if (assignedIds != null)
			{
			}
			bool flag2 = default(bool);
			if (!flag2)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001795")]
		[Cpp2IlInjected.Address(RVA = "0x8B73D0", Offset = "0x8B5DD0", VA = "0x1808B73D0")]
		private void SetFurnitureItem(int furnitureItem)
		{
			//IL_0016: Expected O, but got I4
			//IL_002f: Expected O, but got I4
			//IL_0039: Expected O, but got I4
			//IL_005f: Expected I4, but got I8
			do
			{
				if (((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureData_).ContainsKey((TKey)furnitureItem))
				{
					Furniture furniture = (Furniture)((MapField<TKey, TValue>)(object)_currentProfile.player_.furnitureData_)[(TKey)furnitureItem];
				}
				int num = 0;
				_originalFurniture = (IFurniture)num;
			}
			while (_originalFurniture != null);
			Furniture furniture2 = new Furniture();
			furniture2.furnitureItem_ = furnitureItem;
			furniture2.currentDesign_ = -1;
			_originalFurniture = furniture2;
			FurnitureWorkingCopy furnitureWorkingCopy = (CurrentFurniture = new FurnitureWorkingCopy(_originalFurniture));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001796")]
		[Cpp2IlInjected.Address(RVA = "0x8B7D80", Offset = "0x8B6780", VA = "0x1808B7D80")]
		[AsyncStateMachine(typeof(_003CWaitForLoading_003Ed__49))]
		public Task WaitForLoading()
		{
			int num = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001797")]
		[Cpp2IlInjected.Address(RVA = "0x8B5940", Offset = "0x8B4340", VA = "0x1808B5940")]
		public void Cleanup()
		{
			//Discarded unreachable code: IL_002d
			//IL_001b: Expected O, but got I8
			Coroutine loadingCoroutine = _loadingCoroutine;
			if (loadingCoroutine != null)
			{
				StopCoroutine(loadingCoroutine);
				_loadingCoroutine = (Coroutine)0;
			}
			decalRenderingTool.StopProjector();
			UnloadAllFurniture();
		}

		[Cpp2IlInjected.Token(Token = "0x6001798")]
		[Cpp2IlInjected.Address(RVA = "0x8B76D0", Offset = "0x8B60D0", VA = "0x1808B76D0")]
		private void UnloadAllAssets()
		{
			UnloadAllFurniture();
		}

		[Cpp2IlInjected.Token(Token = "0x6001799")]
		[Cpp2IlInjected.Address(RVA = "0x8B7870", Offset = "0x8B6270", VA = "0x1808B7870")]
		private void UnloadFurniture(int id)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600179A")]
		[Cpp2IlInjected.Address(RVA = "0x8B76E0", Offset = "0x8B60E0", VA = "0x1808B76E0")]
		private void UnloadAllFurniture()
		{
			//Discarded unreachable code: IL_0011
			Dictionary<int, LoadedFurniture>.ValueCollection values = (Dictionary<int, LoadedFurniture>.ValueCollection)(object)((Dictionary<TKey, TValue>)(object)_loadedFurniture).get_Values();
			bool flag = default(bool);
			if (!flag)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600179B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E80", Offset = "0x8B6880", VA = "0x1808B7E80")]
		public FurnitureAppearance()
		{
		}//IL_000d: Expected I4, but got I8

	}
}
