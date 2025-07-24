using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;



public static class Utilstest
{
#if UNITY_EDITOR
    [UnityEditor.MenuItem("Ebac/Test1")]
    public static void Test()
    {
        Debug.Log("Test");
    }

    [UnityEditor.MenuItem("Ebac/Test2 %g")]
    public static void Test2()
    {
        Debug.Log("Test2");
    }

    [UnityEditor.MenuItem("Ebac/Criar Cubo")]
    public static void Test3()
    {
       GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
       cube.name = "Cubo Criado";
       

    }


#endif


    public static void Scale(this Transform t, float size = 1.2f)
    {
        t.localScale = Vector3.one * size;
    }

    public static void Scale(this GameObject t, float size = 1.2f)
    {
        t.transform.localScale = Vector3.one * size;
    }

    public static void ScaleVector(this Vector3 t, float size = 1.2f)
    {
        //t.localScale = Vector3.one * size;
    }



    
    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static T GetRandomButNotSame<T>(this List<T> list, T unique)
    {
        if (list.Count == 1)
            return unique;

        int randomIndex = Random.Range(0, list.Count);
        return list[randomIndex];
    }
}
