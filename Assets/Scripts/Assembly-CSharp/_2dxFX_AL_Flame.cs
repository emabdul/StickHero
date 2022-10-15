using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Advanced Lightning/Flame")]
public class _2dxFX_AL_Flame : MonoBehaviour
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
	public Texture2D __MainTex2;

	[HideInInspector]
	public float _Alpha;

	[HideInInspector]
	public float _Speed;

	[HideInInspector]
	public float _Intensity;

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

	public _2dxFX_AL_Flame()
		: base()
	{
	}
}