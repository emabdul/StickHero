Shader "Shader Graphs/Dissolve" {
	Properties {
		_AlbedoColor ("AlbedoColor", Vector) = (0.3176471,0.3921569,1,0)
		_NoiseScale ("Noise Scale", Float) = 30
		_AlphaClipThreshhold ("AlphaClipThreshold", Float) = 0
		_Thickness ("Thickness", Float) = 0.05
		_EdgeColor ("EdgeColor", Vector) = (0.4339623,0,0,0)
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Hidden/Shader Graph/FallbackError"
}