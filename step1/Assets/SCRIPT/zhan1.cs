using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.Events;

public class zhan1 : MonoBehaviour
{

    private float ftime = 0f;
    private float ftime2 = 0f;
    public bool start = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame




    void Update()
    {
        if (ftime2 < 5f) { 
             ftime2 += Time.deltaTime;
         }
        if (ftime2 >= 5f)
        {
            ftime2 = 6f;
            if (start)
            {
                ftime += Time.deltaTime;

                if (ftime >= 5f)
                {
                    gameObject.transform.Rotate(90, 0, 0);
                    ftime = 0f;
                }
            }
            print(ftime);

            //while(true)
            //transform.Rotate(Vector3.up, Time.deltaTime * time);
            //transform.eulerAngles = new Vector3(0, -90, 0);
            //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90,0 ), 0.5f);
        }
    }
}
