using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{




    private void Start()
    {
        int array;
        {
            int[] points = { 19, 48, 78, 47, 97 };
            for (int num = 0; num < 4; num++) { Debug.Log(points[num]); };
            for (int i = 4; i > 0; i--) { Debug.Log(points[i]); }
        }
    }

    private void Update()
    {

    }
}



