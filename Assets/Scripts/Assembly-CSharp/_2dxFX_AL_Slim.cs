using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Advanced Lightning/Slim")]
public class _2dxFX_AL_Slim : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	[HideInInspector]
	public bool AddShadow;

	[HideInInspector]
	public bool ReceivedShadow;

	[HideInInspector]
	public int BlendMode;

	private string shader;

	[HideInInspector]
	public float _Alpha;

	[HideInInspector]
	public Texture2D __MainTex2;

	[HideInInspector]
	public float TurnToSlim;

	[HideInInspector]
	public float SlimDistortion;

	[HideInInspector]
	public float Speed;

	[HideInInspector]
	public float EValue;

	[HideInInspector]
	public float Light;

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

	public _2dxFX_AL_Slim()
		: base()
	{
	}
}
