using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputObservable
{
    void OnLeft();
    void OnRight();
    void OnUp();
    void OnDown();
    void OnTouch(Vector2[] position);
}