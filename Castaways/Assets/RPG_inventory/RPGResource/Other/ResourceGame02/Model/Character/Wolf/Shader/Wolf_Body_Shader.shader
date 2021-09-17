// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "Wolf_Body_Material"
{
	Properties
	{
		_hero_019_wolf_01_diff("hero_019_wolf_01_diff", 2D) = "white" {}
		_hero_019_wolf_01_ddna("hero_019_wolf_01_ddna", 2D) = "white" {}
		[HideInInspector] _texcoord( "", 2D ) = "white" {}
		[HideInInspector] __dirty( "", Int ) = 1
	}

	SubShader
	{
		Tags{ "RenderType" = "Opaque"  "Queue" = "Geometry+0" }
		Cull Back
		CGPROGRAM
		#pragma target 3.0
		#pragma surface surf Standard keepalpha addshadow fullforwardshadows 
		struct Input
		{
			float2 uv_texcoord;
		};

		uniform sampler2D _hero_019_wolf_01_ddna;
		uniform float4 _hero_019_wolf_01_ddna_ST;
		uniform sampler2D _hero_019_wolf_01_diff;
		uniform float4 _hero_019_wolf_01_diff_ST;

		void surf( Input i , inout SurfaceOutputStandard o )
		{
			float2 uv_hero_019_wolf_01_ddna = i.uv_texcoord * _hero_019_wolf_01_ddna_ST.xy + _hero_019_wolf_01_ddna_ST.zw;
			o.Normal = tex2D( _hero_019_wolf_01_ddna, uv_hero_019_wolf_01_ddna ).rgb;
			float2 uv_hero_019_wolf_01_diff = i.uv_texcoord * _hero_019_wolf_01_diff_ST.xy + _hero_019_wolf_01_diff_ST.zw;
			o.Albedo = tex2D( _hero_019_wolf_01_diff, uv_hero_019_wolf_01_diff ).rgb;
			o.Alpha = 1;
		}

		ENDCG
	}
	Fallback "Diffuse"
	CustomEditor "ASEMaterialInspector"
}
/*ASEBEGIN
Version=16400
539;102;1352;728;1039;93;1;True;False
Node;AmplifyShaderEditor.SamplerNode;3;-736,21;Float;True;Property;_hero_019_wolf_01_ddna;hero_019_wolf_01_ddna;1;0;Create;True;0;0;False;0;f54d2b0e9a7b3e84e84f5284df33adc1;f54d2b0e9a7b3e84e84f5284df33adc1;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.SamplerNode;1;-735,-172;Float;True;Property;_hero_019_wolf_01_diff;hero_019_wolf_01_diff;0;0;Create;True;0;0;False;0;9c8846b6eb3d4fb4d8e189c2e9ef1035;9c8846b6eb3d4fb4d8e189c2e9ef1035;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.StandardSurfaceOutputNode;0;0,0;Float;False;True;2;Float;ASEMaterialInspector;0;0;Standard;Wolf_Body_Material;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;Back;0;False;-1;0;False;-1;False;0;False;-1;0;False;-1;False;0;Opaque;0.5;True;True;0;False;Opaque;;Geometry;All;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;0;False;-1;False;0;False;-1;255;False;-1;255;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;False;2;15;10;25;False;0.5;True;0;0;False;-1;0;False;-1;0;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;0;0,0,0,0;VertexOffset;True;False;Cylindrical;False;Relative;0;;-1;-1;-1;-1;0;False;0;0;False;-1;-1;0;False;-1;0;0;0;False;0.1;False;-1;0;False;-1;16;0;FLOAT3;0,0,0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT3;0,0,0;False;7;FLOAT3;0,0,0;False;8;FLOAT;0;False;9;FLOAT;0;False;10;FLOAT;0;False;13;FLOAT3;0,0,0;False;11;FLOAT3;0,0,0;False;12;FLOAT3;0,0,0;False;14;FLOAT4;0,0,0,0;False;15;FLOAT3;0,0,0;False;0
WireConnection;0;0;1;0
WireConnection;0;1;3;0
ASEEND*/
//CHKSM=3755A529C450840C94514BF2E1CFA958964CCF23