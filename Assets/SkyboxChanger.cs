using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var colorA = new Color(Random.Range(.5f, 1f), Random.Range(.5f, 1f), Random.Range(.5f, 1f));
        var colorB = new Color(Random.Range(.5f, 1f), Random.Range(.5f, 1f), Random.Range(.5f, 1f));

        var skyboxMtl = RenderSettings.skybox;
        skyboxMtl.SetColor("_SkyTint", colorA);
        skyboxMtl.SetColor("_GroundColor", colorB);
        RenderSettings.skybox = skyboxMtl;
    }
}
