using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketScript : MonoBehaviour
{
    [SerializeField] int pointForWin;
    int actualPointNumber;

    private void Start()
    {
        actualPointNumber = pointForWin;
    }
    

    public void ReducePoint()
    {
        actualPointNumber--;
        if(actualPointNumber == 0)
        {
            Debug.Log("Win ! ");
        }
    }
}
