using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingGenerics : MonoBehaviour
{
   
    void Start()
    {
        TestMultiGenerics<int,string>(56, "asdf");
    }


    private void TestMultiGenerics<T1, T2>(T1 t1, T2 t2)
    {
        Debug.Log("t1: " + t1 + ", " + t1.GetType());
        Debug.Log("t2: " + t2 + ", " +t2.GetType());
    }

}
