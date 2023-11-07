using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingConstructionScript : MonoBehaviour
{
    // ResourceGatheringScript reference
    public ResourceGatheringScript resourceGatheringScript;

    // Stats for the shelter building
    private int shelterCapacity = 10;

    // Stats for the energy generator
    private int energyProductionRate = 5;

    // Stats for the biodiversity farm
    private int foodProductionRate = 3;

    // Stats for the advanced laboratory
    private int researchRate = 2;


    // Function to construct a shelter
    public void ConstructShelter(int resource1Cost, int resource2Cost, int resource3Cost, int resource4Cost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.resourceType1 >= resource1Cost && resourceGatheringScript.resourceType2 >= resource2Cost && resourceGatheringScript.resourceType3 >= resource3Cost && resourceGatheringScript.resourceType4 >= resource4Cost)
        {
            resourceGatheringScript.SpendResources(resource1Cost, resource2Cost, 0, 0);
            Debug.Log("Constructed the Shelter Building with capacity: " + shelterCapacity);
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to construct the Shelter Building.");
        }
    }

    // Function to construct an energy generator
    public void ConstructEnergyGenerator(int resource1Cost, int resource2Cost, int resource3Cost, int resource4Cost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.resourceType1 >= resource1Cost && resourceGatheringScript.resourceType2 >= resource2Cost && resourceGatheringScript.resourceType3 >= resource3Cost && resourceGatheringScript.resourceType4 >= resource4Cost)
        {
            resourceGatheringScript.SpendResources(0, resource2Cost, resource3Cost, 0);
            Debug.Log("Constructed the EnergyGenerator Building with production rate: " + energyProductionRate);
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to Constructed the EnergyGenerator");
        }
    }

    // Function to construct a biodiversity farm
    public void ConstructBiodiversityFarm(int resource1Cost, int resource2Cost, int resource3Cost, int resource4Cost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.resourceType1 >= resource1Cost && resourceGatheringScript.resourceType2 >= resource2Cost && resourceGatheringScript.resourceType3 >= resource3Cost && resourceGatheringScript.resourceType4 >= resource4Cost)
        {
            resourceGatheringScript.SpendResources(resource1Cost, 0, resource3Cost, 0);
            Debug.Log("Constructed the Bio diversity Farm with Farming Rate:" + foodProductionRate);
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to Constructed the Bio diversity Farm.");
        }
    }

    // Function to construct an advanced laboratory
    public void ConstructAdvancedLaboratory(int resource1Cost, int resource2Cost, int resource3Cost, int resource4Cost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.resourceType1 >= resource1Cost && resourceGatheringScript.resourceType2 >= resource2Cost && resourceGatheringScript.resourceType3 >= resource3Cost && resourceGatheringScript.resourceType4 >= resource4Cost)
        {
            resourceGatheringScript.SpendResources(resource1Cost, 0, 0, resource4Cost);
            Debug.Log("Constructed the Advanced Laboratory with research rate:" + researchRate);
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to construct the random building 2.");
        }
    }

    // Function to construct a random building 1
    public void ConstructBioDome(int resource1Cost, int resource2Cost, int resource3Cost, int resource4Cost)
    {
        if (resourceGatheringScript.resourceType1 >= resource1Cost && resourceGatheringScript.resourceType2 >= resource2Cost && resourceGatheringScript.resourceType3 >= resource3Cost && resourceGatheringScript.resourceType4 >= resource4Cost)
        {
            resourceGatheringScript.SpendResources(resource1Cost, resource2Cost, resource3Cost, 0);
            Debug.Log("Constructed the Random Building 1.");
            // Implement logic to construct the random building 1
        }
        else
        {
            Debug.Log("Insufficient resources to construct the random building 1.");
        }
    }

    public void ConstructOxygenFarm(int resource1Cost, int resource2Cost, int resource3Cost, int resource4Cost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.resourceType1 >= resource1Cost && resourceGatheringScript.resourceType2 >= resource2Cost && resourceGatheringScript.resourceType3 >= resource3Cost && resourceGatheringScript.resourceType4 >= resource4Cost)
        {
            resourceGatheringScript.SpendResources(0, 0, 0, resource4Cost);
            Debug.Log("Constructed the Random Building 2.");
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to construct the random building 2.");
        }
    }

    public void ConstructFoodStorage(int resource1Cost, int resource2Cost, int resource3Cost, int resource4Cost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.resourceType1 >= resource1Cost && resourceGatheringScript.resourceType2 >= resource2Cost && resourceGatheringScript.resourceType3 >= resource3Cost && resourceGatheringScript.resourceType4 >= resource4Cost)
        {
            resourceGatheringScript.SpendResources(resource1Cost, 0, 0, resource4Cost);
            Debug.Log("Constructed the Random Building 2.");
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to construct the random building 2.");
        }
    }

    public void ConstructLiveStockFarm(int resource1Cost, int resource2Cost, int resource3Cost, int resource4Cost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.resourceType1 >= resource1Cost && resourceGatheringScript.resourceType2 >= resource2Cost && resourceGatheringScript.resourceType3 >= resource3Cost && resourceGatheringScript.resourceType4 >= resource4Cost)
        {
            resourceGatheringScript.SpendResources(0, resource2Cost, 0, 0);
            Debug.Log("Constructed the Random Building 2.");
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to construct the random building 2.");
        }
    }
}
