using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Standard/Mystic_Distortion_Additive")]
public class _2dxFX_Mystic_Distortion_Additive : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	private string shader;

	[HideInInspector]
	public float _Alpha;

	[HideInInspector]
	public float _Pitch;

	[HideInInspector]
	public bool Pitch_Wave;

	[HideInInspector]
	public float _Pitch_Speed;

	[HideInInspector]
	public float _Pitch_Offset;

	[HideInInspector]
	public float _OffsetX;

	[HideInInspector]
	public float _OffsetY;

	[HideInInspector]
	public float _DistanceX;

	[HideInInspector]
	public float _DistanceY;

	[HideInInspector]
	public float _WaveTimeX;

	[HideInInspector]
	public float _WaveTimeY;

	[HideInInspector]
	public bool AutoPlayWaveX;

	[HideInInspector]
	public float AutoPlaySpeedX;

	[HideInInspector]
	public bool AutoPlayWaveY;

	[HideInInspector]
	public float AutoPlaySpeedY;

	[HideInInspector]
	public bool AutoRandom;

	[HideInInspector]
	public float AutoRandomRange;

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

	public _2dxFX_Mystic_Distortion_Additive()
		: base()
	{
	}
}
