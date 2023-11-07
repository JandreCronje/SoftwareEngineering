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
    public void ConstructShelter(int FoodCost, int EnergyCost, int OxygenCost, int MineralsCost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.Food >= FoodCost && resourceGatheringScript.Energy >= EnergyCost && resourceGatheringScript.Oxygen >= OxygenCost && resourceGatheringScript.Minerals >= MineralsCost)
        {
            resourceGatheringScript.SpendResources(FoodCost, EnergyCost, 0, 0);
            Debug.Log("Constructed the Shelter Building with capacity: " + shelterCapacity);
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to construct the Shelter Building.");
        }
    }

    // Function to construct an energy generator
    public void ConstructEnergyGenerator(int FoodCost, int EnergyCost, int OxygenCost, int MineralsCost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.Food >= FoodCost && resourceGatheringScript.Energy >= EnergyCost && resourceGatheringScript.Oxygen >= OxygenCost && resourceGatheringScript.Minerals >= MineralsCost)
        {
            resourceGatheringScript.SpendResources(0, EnergyCost, OxygenCost, 0);
            Debug.Log("Constructed the EnergyGenerator Building with production rate: " + energyProductionRate);
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to Constructed the EnergyGenerator");
        }
    }

    // Function to construct a biodiversity farm
    public void ConstructBiodiversityFarm(int FoodCost, int EnergyCost, int OxygenCost, int MineralsCost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.Food >= FoodCost && resourceGatheringScript.Energy >= EnergyCost && resourceGatheringScript.Oxygen >= OxygenCost && resourceGatheringScript.Minerals >= MineralsCost)
        {
            resourceGatheringScript.SpendResources(FoodCost, 0, OxygenCost, 0);
            Debug.Log("Constructed the Bio diversity Farm with Farming Rate:" + foodProductionRate);
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to Constructed the Bio diversity Farm.");
        }
    }

    // Function to construct an advanced laboratory
    public void ConstructAdvancedLaboratory(int FoodCost, int EnergyCost, int OxygenCost, int MineralsCost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.Food >= FoodCost && resourceGatheringScript.Energy >= EnergyCost && resourceGatheringScript.Oxygen >= OxygenCost && resourceGatheringScript.Minerals >= MineralsCost)
        {
            resourceGatheringScript.SpendResources(FoodCost, 0, 0, MineralsCost);
            Debug.Log("Constructed the Advanced Laboratory with research rate:" + researchRate);
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to construct the random building 2.");
        }
    }

    // Function to construct a random building 1
    public void ConstructBioDome(int FoodCost, int EnergyCost, int OxygenCost, int MineralsCost)
    {
        if (resourceGatheringScript.Food >= FoodCost && resourceGatheringScript.Energy >= EnergyCost && resourceGatheringScript.Oxygen >= OxygenCost && resourceGatheringScript.Minerals >= MineralsCost)
        {
            resourceGatheringScript.SpendResources(FoodCost, EnergyCost, OxygenCost, 0);
            Debug.Log("Constructed the Random Building 1.");
            // Implement logic to construct the random building 1
        }
        else
        {
            Debug.Log("Insufficient resources to construct the random building 1.");
        }
    }

    public void ConstructOxygenFarm(int FoodCost, int EnergyCost, int OxygenCost, int MineralsCost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.Food >= FoodCost && resourceGatheringScript.Energy >= EnergyCost && resourceGatheringScript.Oxygen >= OxygenCost && resourceGatheringScript.Minerals >= MineralsCost)
        {
            resourceGatheringScript.SpendResources(0, 0, 0, MineralsCost);
            Debug.Log("Constructed the Random Building 2.");
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to construct the random building 2.");
        }
    }

    public void ConstructFoodStorage(int FoodCost, int EnergyCost, int OxygenCost, int MineralsCost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.Food >= FoodCost && resourceGatheringScript.Energy >= EnergyCost && resourceGatheringScript.Oxygen >= OxygenCost && resourceGatheringScript.Minerals >= MineralsCost)
        {
            resourceGatheringScript.SpendResources(FoodCost, 0, 0, MineralsCost);
            Debug.Log("Constructed the Random Building 2.");
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to construct the random building 2.");
        }
    }

    public void ConstructLiveStockFarm(int FoodCost, int EnergyCost, int OxygenCost, int MineralsCost)
    {
        // Check if there are enough resources to construct the building
        if (resourceGatheringScript.Food >= FoodCost && resourceGatheringScript.Energy >= EnergyCost && resourceGatheringScript.Oxygen >= OxygenCost && resourceGatheringScript.Minerals >= MineralsCost)
        {
            resourceGatheringScript.SpendResources(0, EnergyCost, 0, 0);
            Debug.Log("Constructed the Random Building 2.");
            // Implement logic to construct the random building 2
        }
        else
        {
            Debug.Log("Insufficient resources to construct the random building 2.");
        }
    }
}
