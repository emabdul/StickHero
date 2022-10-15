using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Advanced Lightning/JellyAutoMove")]
public class _2dxFX_AL_JellyAutoMove : MonoBehaviour
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
	public float Heat;

	[HideInInspector]
	public float RandomPos;

	[HideInInspector]
	public float Inside;

	[HideInInspector]
	public float Stabilisation;

	[HideInInspector]
	public float Speed;

	[HideInInspector]
	public int ShaderChange;

	private Material tempMaterial;

	private Material defaultMaterial;

	private Image CanvasImage;

	private Vector3 SaveMove1;

	private Vector3 SaveMove2;

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

	public _2dxFX_AL_JellyAutoMove()
		: base()
	{
	}
}
