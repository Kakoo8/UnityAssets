using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flexor : MonoBehaviour
{
    [Header("Valor Threshold")]
    public int valor;
    [Header("Valor Threshold")]
    public int flexor;
    [Header("Valor Threshold")]
    public int valorFlexor;
    public OpenGloveScript UGlove;


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
        valorFlexor = value;
    }

    void calibrarFlexores()
    {
        UGlove.api.calibrateFlexors(UGlove.glove);
    } 

    void definirThreshold(int valor)
    {
        UGlove.api.setThreshold(UGlove.glove,valor);
    }
}
