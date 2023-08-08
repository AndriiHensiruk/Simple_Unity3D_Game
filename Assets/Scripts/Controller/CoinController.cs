using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    public int rotateSpeed = 1;


    
    private void Update()
    {
       if(gameObject != null)
        {
            CoinRotation(rotateSpeed);
        }
    }

    private void CoinRotation(int rotateSpeed)
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
    private void Pickup()
    {
        //other.GetComponent<PlayerController>.coints++;
        Destroy(gameObject); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PlayerController player) )
        {
            Pickup();
        }
    }
}
