using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Standard/Pattern")]
public class _2dxFX_Pattern : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	private string shader;

	[HideInInspector]
	public float _Alpha;

	[HideInInspector]
	public Texture2D __MainTex2;

	[HideInInspector]
	public float _OffsetX;

	[HideInInspector]
	public float _OffsetY;

	[HideInInspector]
	public bool _AutoScrollX;

	[HideInInspector]
	public float _AutoScrollSpeedX;

	[HideInInspector]
	public bool _AutoScrollY;

	[HideInInspector]
	public float _AutoScrollSpeedY;

	[HideInInspector]
	private float _AutoScrollCountX;

	[HideInInspector]
	private float _AutoScrollCountY;

	[HideInInspector]
	public int ShaderChange;

	private Material tempMaterial;

	private Material defaultMaterial;

	private Image CanvasImage;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void CallUpdate()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public _2dxFX_Pattern()
		: base()
	{
	}
}
