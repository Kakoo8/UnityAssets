using System.Collections;
using System.Collections.Generic;
using OpenGlove_API_C_Sharp_HL;
using OpenGlove_API_C_Sharp_HL.ServiceReference1;
using System;
using UnityEngine;
using UnityEditor;
using System.Linq;

[Serializable]
public class OpenGloveScript : MonoBehaviour
{
    public OpenGlove_API_C_Sharp_HL.OpenGloveAPI api;
    public Glove glove;
    [Header("Guantes Conectados")]
    
    public int connectedGloves;




    [Header("Regiones en el guante")]
    public List<String> regionstoshow = new List<String>();
    static public List<String> regions = new List<String>() ;

        
    [HideInInspector]
    public String region;
    [HideInInspector]
    public  List<Glove> gloves;
    [HideInInspector]
    public int selected;


    public void Awake()
    {
        

        api = OpenGloveAPI.GetInstance();
        try
        {

            gloves = api.Devices;

            Debug.Log(gloves);
        }
        catch
        {
            Debug.Log("ERROR: El servicio no esta activo");
        }
 
    }

    public void Start()
    {

        glove = gloves[selected];
        connectedGloves = gloves.Count;
        regions = glove.GloveConfiguration.GloveProfile.Mappings.Keys.ToList();
        regionstoshow = regions;
    }

    public void Update()
    {
        
    }

    public void AgregarRegion(String region)
    {
        regions.Add(region);
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
