using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGatheringScript : MonoBehaviour
{
    public int resourceType1;
    public int resourceType2;
    public int resourceType3;

    // Function to deduct resources when spent on buildings
    public void SpendResources(int amount1, int amount2, int amount3)
    {
        resourceType1 -= amount1;
        resourceType2 -= amount2;
        resourceType3 -= amount3;
    }
}
