using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColourChanger : MonoBehaviour

{
    public Slider  colorSlider;
     public Material cubeMaterial;
    // Start is called before the first frame update
   private void Start()
    {
        colorSlider.onValueChanged.AddListener(ChangeCubeColor);
    }
   

    private void ChangeCubeColor(float value)
    {
        cubeMaterial.color = Color.Lerp(Color.blue, Color.yellow, value);
    }

    
}
