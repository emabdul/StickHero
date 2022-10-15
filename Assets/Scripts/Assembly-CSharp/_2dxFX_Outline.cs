using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Standard/Outline")]
public class _2dxFX_Outline : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	private string shader;

	[HideInInspector]
	public float _Alpha;

	[HideInInspector]
	public Color _ColorX;

	[HideInInspector]
	public float _OutLineSpread;

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

	public _2dxFX_Outline()
		: base()
	{
	}
}
