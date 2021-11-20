using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System.Threading.Tasks;
using Debug = UnityEngine.Debug;

public class Test : MonoBehaviour
{
    public OpenGloveScript UGlove;
    // Start is called before the first frame update
    [HideInInspector]
    public int region;
    List<int> regions = new List<int>() { 0,1,2,3,25 };
    List<int> intensities = new List<int>() { 255,255,255,255,255 };
    List<int> off = new List<int>() { 0,0,0,0,0};

    public int iteracion;
    public void Start()
    {
        Testing();
        Debug.Log("Test Listo");

    }
    // Update is called once per frame
    public void Testing()
    {
        Stopwatch timeMeasure = new Stopwatch();
        
        Task.Run(async delegate
        {
            for (int region = 0; region < 1000; region++)
            {
                timeMeasure.Reset();
                timeMeasure.Start();
                UGlove.api.Activate(UGlove.glove, regions ,intensities );

                Debug.Log(region);
                timeMeasure.Stop();
                await Task.Delay(250);
                timeMeasure.Start();

                UGlove.api.Activate(UGlove.glove, regions, off);
                timeMeasure.Stop();
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Claudio\Desktop\TestPenta.txt", true))
                file.WriteLine(timeMeasure.Elapsed.TotalMilliseconds);

            }
        });
            
       

    }
}
