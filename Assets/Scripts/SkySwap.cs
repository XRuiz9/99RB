using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySwap : MonoBehaviour
{
    public Material daySkybox;
    public GameObject dawnLight;
    public GameObject dayLight;
    public GameObject balloon;

    public GameObject sign;
    private Renderer rend;

    private void Start()
    {
        rend = sign.GetComponent<Renderer>();
    }

    public void SwapSkies()
    {
        RenderSettings.skybox = daySkybox;
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Skybox;
        RenderSettings.ambientIntensity = 0.64f;

        dawnLight.SetActive(false);
        dayLight.SetActive(true);

        balloon.SetActive(false);
    }

    public void LightsOut()
    {
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;

        dayLight.SetActive(false);

        rend.material.mainTextureOffset = new Vector2(0.0f, 0.5f);
;    }
}
