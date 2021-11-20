using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flexor : MonoBehaviour
{
    public OpenGloveScript UGlove;
    
    [HideInInspector]
    public int flexor;
    [HideInInspector]
    public int selected;
    [Header("")]
    public int flexorValue;
    [Header("")]
    public int threshold;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UGlove.api.getDataReceiver(UGlove.glove).fingersFunction += Flexor_fingersFunction;
    }

    private void Flexor_fingersFunction(int region, int value)
    {
        flexor = region;
        flexorValue = value;
    }

    public void calibrateFlexors()
    {
        UGlove.api.calibrateFlexors(UGlove.glove);
    } 

    public void setThreshold(int value)
    {
        UGlove.api.setThreshold(UGlove.glove,value);
    }
}
