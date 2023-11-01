using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingConstructionScript : MonoBehaviour
{
    // ResourceGatheringScript reference
    public ResourceGatheringScript resourceGatheringScript;

    // Function to construct a shelter
    public void ConstructShelter(int shelterCost)
    {
        if (resourceGatheringScript.resourceType1 >= shelterCost)
        {
            resourceGatheringScript.SpendResources(shelterCost, 0, 0);
            Debug.Log("constructed the shelter.");
            // Implement logic to construct the shelter
        }
        else
        {
            Debug.Log("Insufficient resources to construct the shelter.");
        }
    }

    // Function to construct an energy generator
    public void ConstructEnergyGenerator(int mineralCost, int crystalCost)
    {
        if (resourceGatheringScript.resourceType1 >= mineralCost && resourceGatheringScript.resourceType2 >= crystalCost)
        {
            resourceGatheringScript.SpendResources(mineralCost, crystalCost, 0);
            Debug.Log("constructed the energy Generator.");
            // Implement logic to construct the energy generator
        }
        else
        {
            Debug.Log("Insufficient resources to construct the energy generator.");
        }
    }

    // Function to construct a biodiversity farm
    public void ConstructBiodiversityFarm(int crystalCost, int biomassCost)
    {
        if (resourceGatheringScript.resourceType2 >= crystalCost && resourceGatheringScript.resourceType3 >= biomassCost)
        {
            resourceGatheringScript.SpendResources(0, crystalCost, biomassCost);
            Debug.Log("constructed the Biodiversity Farm.");
            // Implement logic to construct the biodiversity farm
        }
        else
        {
            Debug.Log("Insufficient resources to construct the biodiversity farm.");
        }
    }

    // Function to construct an advanced laboratory
    public void ConstructAdvancedLaboratory(int mineralCost, int crystalCost, int biomassCost)
    {
        if (resourceGatheringScript.resourceType1 >= mineralCost && resourceGatheringScript.resourceType2 >= crystalCost && resourceGatheringScript.resourceType3 >= biomassCost)
        {
            resourceGatheringScript.SpendResources(mineralCost, crystalCost, biomassCost);
            Debug.Log("constructed the Laboratory.");
            // Implement logic to construct the advanced laboratory
        }
        else
        {
            Debug.Log("Insufficient resources to construct the advanced laboratory.");
        }
    }
}
