using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    ObjectData cube1;
    [SerializeField]
    ObjectData cube2;
    [SerializeField]
    Color32 colorCube1;
     [SerializeField]
    Color32 colorCube2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube1.matterailColor=colorCube1;
        cube2.matterailColor=colorCube2;
    }
}
