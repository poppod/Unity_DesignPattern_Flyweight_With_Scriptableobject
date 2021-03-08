using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHandler : MonoBehaviour
{
    Material m_Mat ;
    MeshRenderer m_MeshRenderer=new MeshRenderer(); 
    public ObjectData m_ObjData;
    // Start is called before the first frame update
    void Start()
    {
        m_MeshRenderer=GetComponent<MeshRenderer>();
        m_Mat=m_MeshRenderer.material;
        //m_Mat.color=Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        m_Mat.color=m_ObjData.matterailColor;
    }
}
