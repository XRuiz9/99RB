using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySwap : MonoBehaviour
{
    public Material daySkybox;
    public GameObject dawnLight;
    public GameObject dayLight;
    public GameObject balloon;

    public void SwapSkies()
    {
        RenderSettings.skybox = daySkybox;
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Skybox;
        RenderSettings.ambientIntensity = 0.64f;

        dawnLight.SetActive(false);
        dayLight.SetActive(true);

        balloon.SetActive(false);
    }
}
