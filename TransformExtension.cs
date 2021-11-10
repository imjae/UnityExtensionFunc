using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformExtension
{
    public static GameObject GetRootObject(this Transform current)
    {
        GameObject result = current;

        while(result.parent)
        {
            result = result.parent;
        }

        return result;
    }

    public static List<GameObject> GetChildsForList(this Transform current)
    {
        List<GameObject> result = new List<GameObject>();

        for(int i=0; i<current.childCount; i++)
        {
            result.Add(current.GetChild(i));
        }

        return result;
    }
}
