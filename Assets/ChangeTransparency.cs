using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTransparency : MonoBehaviour
{
    // Start is called before the first frame update
    float alphaValue = 50;
    public Slider slide;
    public MeshRenderer rend;
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void sliderchange(float slideVal)
    {
        Material[] materials = rend.materials;
        slideVal /= 255;
        
        materials[1].SetColor("_Color", new Vector4(1, 1, 1, slideVal));
        Debug.Log("Slide Val is: " + slideVal);
       
    }

}
