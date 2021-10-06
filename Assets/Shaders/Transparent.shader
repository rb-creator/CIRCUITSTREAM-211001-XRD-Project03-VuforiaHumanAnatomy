Shader "Custom/Transparent"
{
    Properties
    {
        _MainTex ("Main Texture Map", 2D) = "white" {}
    }
    SubShader
    {
       Tags { "Queue" = "Transparent+1"}
       
       Pass { Blend Zero One }

    }
}
