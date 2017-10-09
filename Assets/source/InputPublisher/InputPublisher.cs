using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPublisher : MonoBehaviour {

    private List<IInputObservable> __observers;

    private void Awake()
    {
        __observers = new List<IInputObservable>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            foreach (IInputObservable observer in __observers)
            {
                observer.OnLeft();
            }
        }
		if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            foreach (IInputObservable observer in __observers)
            {
                observer.OnRight();
            }
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            foreach (IInputObservable observer in __observers)
            {
                observer.OnUp();
            }
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            foreach (IInputObservable observer in __observers)
            {
                observer.OnDown();
            }
        }
        if (Input.touchCount > 0)
        {
            int touchCount = Input.touchCount;
            Vector2[] touchPosition = new Vector2[touchCount];
            for (int i = 0; i < touchCount; i++)
            {
                touchPosition[i] = Input.GetTouch(i).position;
            }
            foreach (IInputObservable observer in __observers)
            {
                observer.OnTouch(touchPosition);
            }
        }
	}

    private void OnDestroy()
    {
        __observers.Clear();
    }

    public void AddObserver(IInputObservable observer)
    {
        if (__observers.Contains(observer) == false)
        {
            __observers.Add(observer);
        }
    }

    public void RemoveObserver(IInputObservable observer)
    {
        if (__observers.Contains(observer))
        {
            __observers.Remove(observer);
        }
    }
}
