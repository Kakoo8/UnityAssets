using System.Collections;
using System.Collections.Generic;
using OpenGlove_API_C_Sharp_HL;
using OpenGlove_API_C_Sharp_HL.ServiceReference1;
using System;
using UnityEngine;

public class OpenGloveScript : MonoBehaviour
{
    public OpenGlove_API_C_Sharp_HL.OpenGloveAPI api;
    public Glove glove;
    //public Transform theDest;
    //List<int> regions = new List<int>() { 3,0,2,1,25};
    // List<int> intensity = new List<int>() { 255, 255, 255, 255,255};
    //List<int> intensityOff = new List<int>() { 0, 0, 0, 0 };
    [Header("Guantes")]
    public  List<Glove> gloves;
   

    [Header("Regiones en el guante")]
    public List<int> regions = new List<int>() ;


    



    public void Awake()
    {
        region = 0;
    }
    public void Start()
    {
          api  = OpenGloveAPI.GetInstance();
        try
        {
            
            gloves = api.Devices;
            glove = gloves[1];
            
            Debug.Log(gloves);
        }
        catch
        {
            Debug.Log("ERROR: El servicio no esta activo");
        }
        
     }

    public void Update()
    {
        
    }




    public enum PalmarRegion
    {
        FingerSmallDistal,
        FingerRingDistal,
        FingerMiddleDistal,
        FingerIndexDistal,

        FingerSmallMiddle,
        FingerRingMiddle,
        FingerMiddleMiddle,
        FingerIndexMiddle,

        FingerSmallProximal,
        FingerRingProximal,
        FingerMiddleProximal,
        FingerIndexProximal,

        PalmSmallDistal,
        PalmRingDistal,
        PalmMiddleDistal,
        PalmIndexDistal,

        PalmSmallProximal,
        PalmRingProximal,
        PalmMiddleProximal,
        PalmIndexProximal,

        HypoThenarSmall,
        HypoThenarRing,
        ThenarMiddle,
        ThenarIndex,

        FingerThumbProximal,
        FingerThumbDistal,

        HypoThenarDistal,
        Thenar,

        HypoThenarProximal
    }

    public enum DorsalRegion
    {
        FingerSmallDistal = 29,
        FingerRingDistal,
        FingerMiddleDistal,
        FingerIndexDistal,

        FingerSmallMiddle,
        FingerRingMiddle,
        FingerMiddleMiddle,
        FingerIndexMiddle,

        FingerSmallProximal,
        FingerRingProximal,
        FingerMiddleProximal,
        FingerIndexProximal,

        PalmSmallDistal,
        PalmRingDistal,
        PalmMiddleDistal,
        PalmIndexDistal,

        PalmSmallProximal,
        PalmRingProximal,
        PalmMiddleProximal,
        PalmIndexProximal,

        HypoThenarSmall,
        HypoThenarRing,
        ThenarMiddle,
        ThenarIndex,

        FingerThumbProximal,
        FingerThumbDistal,

        HypoThenarDistal,
        Thenar,

        HypoThenarProximal
    }
}
