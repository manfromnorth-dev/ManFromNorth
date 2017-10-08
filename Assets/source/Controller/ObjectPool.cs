using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T: MonoBehaviour {

    private List<T> __pool;

    public ObjectPool()
    {
        this.__pool = new List<T>();
    }

	private void Generate(int count)
    {
        if (count <= 0)
        {
            return;
        }

        for(int i = 0; i < count; i++)
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.name = "obj" + i;
            // Initializing logic
            obj.AddComponent<T>();
            obj.SetActive(false);
            __pool.Add(obj.GetComponent<T>());
        }
    }

    public List<T> Withdraw(int count)
    {
        if (count <= 0)
        {
            return new List<T>();
        }
        if (__pool.Count < count)
        {
            Generate(count - __pool.Count);
        }
        return __pool.GetRange(0, count);
    }

    
}
