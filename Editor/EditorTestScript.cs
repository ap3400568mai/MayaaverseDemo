using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    #if UNITY_EDITOR

    Debug.Log("this is editor script for testing custom unity package of mayaa verse tech");
        #endif
    }

    
}
