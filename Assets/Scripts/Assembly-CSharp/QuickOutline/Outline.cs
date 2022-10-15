using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace QuickOutline
{
	[DisallowMultipleComponent]
	public class Outline : MonoBehaviour
	{
		public enum Mode
		{
			OutlineAll = 0,
			OutlineVisible = 1,
			OutlineHidden = 2,
			OutlineAndSilhouette = 3,
			SilhouetteOnly = 4
		}

		[Serializable]
		private class ListVector3
		{
			public List<Vector3> data;

			public ListVector3()
				: base()
			{
			}
		}

		private static HashSet<Mesh> registeredMeshes;

		[SerializeField]
		private Mode outlineMode;

		[SerializeField]
		private Color outlineColor;

		[SerializeField]
		private float outlineWidth;

		[SerializeField]
		[Tooltip("Precompute enabled: Per-vertex calculations are performed in the editor and serialized with the object. Precompute disabled: Per-vertex calculations are performed at runtime in Awake(). This may cause a pause for large meshes.")]
		[Header("Optional")]
		private bool precomputeOutline;

		[HideInInspector]
		[SerializeField]
		private List<Mesh> bakeKeys;

		[HideInInspector]
		[SerializeField]
		private List<ListVector3> bakeValues;

		private Renderer[] renderers;

		private Material outlineMaskMaterial;

		private Material outlineFillMaterial;

		private bool needsUpdate;

		public Mode OutlineMode
		{
			get
			{
				return default(Mode);
			}
			set
			{
			}
		}

		public Color OutlineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float OutlineWidth
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Bake()
		{
		}

		private void LoadSmoothNormals()
		{
		}

		private List<Vector3> SmoothNormals(Mesh mesh)
		{
			return null;
		}

		private void UpdateMaterialProperties()
		{
		}

		public Outline()
			: base()
		{
		}
	}
}
