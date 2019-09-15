using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ForceTest : MonoBehaviour
{
    Rigidbody m_Rb;

    public Vector3 m_Dir;


    // Start is called before the first frame update
    void Start()
    {
        m_Rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        m_Rb.AddForce(m_Dir, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
