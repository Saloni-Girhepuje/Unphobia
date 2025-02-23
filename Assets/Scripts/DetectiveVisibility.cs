using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectiveVisibility : MonoBehaviour
{
    public delegate void DestinationFoundDelegate(DetectiveDestination destination);
    public event DestinationFoundDelegate DestinationFound; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent(out DetectiveDestination destination))
        {
            DestinationFound?.Invoke(destination);
        }
    }
}
