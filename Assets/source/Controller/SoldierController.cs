using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierController : MonoBehaviour {
    // object pool
    public ObjectPoolController ObjectPoolController;
    // object list
    private List<Soldier> Soldiers;
    // battlefield
    public Battlefield Battlefield;

    private void Awake()
    {
        // Setup battlefield
    }

    // Use this for initialization
    void Start ()
    {
        Soldiers = ObjectPoolController.RecruitSoldier(10);
        // build object list
        SoldierEnums.Location loc = new SoldierEnums.Location(0, 0);
        foreach (Soldier s in Soldiers)
        {
            SetupSoldier(s);
            s.Location = loc;
            s.transform.SetPositionAndRotation(LocToVec(loc), Quaternion.identity);
            loc += new SoldierEnums.Location(1, 0);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void SetupSoldier(Soldier s)
    {
        s.gameObject.SetActive(true);
        s.isAlive = true;
        s.MovingPriority = 0;
    }

    public static SoldierEnums.Location VecToLoc(Vector3 v)
    {
        return new SoldierEnums.Location((int)v.x, (int)v.y);
    }

    public static Vector3 LocToVec(SoldierEnums.Location v)
    {
        return new Vector3((float)(v.x), (float)(v.y), 0.0f);
    }
}
