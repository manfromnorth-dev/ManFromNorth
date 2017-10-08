using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolController : MonoBehaviour {

    private ObjectPool<Soldier> __poolSoldier;

    private void Awake()
    {
        __poolSoldier = new ObjectPool<Soldier>();
    }

    public List<Soldier> RecruitSoldier(int count)
    {
        return __poolSoldier.Withdraw(count);
    }
}
