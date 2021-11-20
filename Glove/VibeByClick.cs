using System.Collections;
using System.Collections.Generic;
using OpenGlove_API_C_Sharp_HL;
using OpenGlove_API_C_Sharp_HL.ServiceReference1;
using System;
using UnityEngine;
using System.Linq;
[Serializable]
public class VibeByClick : MonoBehaviour
{

    [Header("")]
    [Range(0, 255)]
    public int intensity;


    public OpenGloveScript UGlove;



    [HideInInspector]
    public int region;
    [HideInInspector]
    public int selected;



  
    public void Start()
    {
      
    }


    public void OnMouseDown()
    {

    

        

        Debug.Log(UGlove.glove);
        UGlove.api.Activate(UGlove.glove,this.region, intensity);
        Debug.Log("Bzzz");
        


    }

    public void OnMouseUp()
    {
        this.transform.parent = null;
        
        UGlove.api.Activate(UGlove.glove, this.region, 0);
    }



 
}