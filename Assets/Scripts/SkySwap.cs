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
    public GameObject batteredSign;
    public GameObject signSpot;

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
        signSpot.SetActive(true);

        balloon.SetActive(false);
    }

    public void LightsOut()
    {
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        dayLight.SetActive(false);

        sign.SetActive(false);
        batteredSign.SetActive(true);
;    }
}
