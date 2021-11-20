using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[Serializable]
public class VibeBoard : MonoBehaviour
{


    [Header("")]
    [Range(0, 255)]
    public int intensity;

    
    public OpenGloveScript UGlove;
    


    [HideInInspector]
    public int region;
    [HideInInspector]
    public int selected;
    // Start is called before the first frame update
    public void Start()
    {
       
        

        
    }





    public void OnCollisionStay(Collision collision)
    {
        UGlove.api.Activate(UGlove.glove, this.region, intensity);
        Debug.Log("estoy tocando");
        
    }

    public void OnCollisionExit(Collision collision)
    {
        UGlove.api.Activate(UGlove.glove, this.region, 0);
        Debug.Log("notoco");
    }

}
