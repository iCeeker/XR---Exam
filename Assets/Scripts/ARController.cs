using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ARController : MonoBehaviour
{
    // Reference to the Scale Factor Text which displays the amount of which the content has been scaled
    public Text scaleFactorLable;

    // Initial scale Factor which has been set by the vuforia configuration
    private float initialScaleFactor;

    // Amount, of which the objects have been scaled
    private float currentScaleFactor;


    // Start is called before the first frame update
    void Start()
    {
        initialScaleFactor = VuforiaConfiguration.Instance.Vuforia.VirtualSceneScaleFactor;
        currentScaleFactor = initialScaleFactor;
    }

    // Scale scene according to scene scale factor + scaling factor with slider
    public void SetSceneScale (float scale)
    {
        currentScaleFactor = initialScaleFactor / scale;
        VuforiaConfiguration.Instance.Vuforia.VirtualSceneScaleFactor = currentScaleFactor;

        scaleFactorLable.text = "Skalierungsfaktor: 1 : " + currentScaleFactor;   
    }


}
