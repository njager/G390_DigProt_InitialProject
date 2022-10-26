using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{



    public enum TowerTypes
    {
        Normal,
        Explosibe,
        LongRange,
        Detector
    }

    public TowerTypes towerType;

    // Start is called before the first frame update
    void Start()
    {
        detectionTrigger = GetComponent<SphereCollider>();
        detectionTrigger.radius = _fireRange;
        if(towerType == TowerTypes.LongRange)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToTarget()
    {
        Vector3 targetDir = (targetLocation - transform.position).normalized;
        transform.position 
    }
}
