using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGatheringScript : MonoBehaviour
{
    public int Food;
    public int Energy;
    public int Oxygen;
    public int Minerals;

    private int baseResourceDemand = 1; // Base demand for each resource per population

    // Function to deduct resources when spent on buildings
    public void SpendResources(int amount1, int amount2, int amount3, int amount4)
    {
        Food -= amount1;
        Energy -= amount2;
        Oxygen -= amount3;
        Minerals -= amount4;
    }

    // Function to deduct food when consumed by the population
    public void ConsumeFood(int amount)
    {
        if (Food >= amount)
        {
            Food -= amount;
        }
        else
        {
            Debug.Log("Not enough food to consume.");
            // Optionally handle the consequences of not having enough food
        }
    }

    // Function to deduct energy when consumed by the population
    public void ConsumeEnergy(int amount)
    {
        if (Energy >= amount)
        {
            Energy -= amount;
        }
        else
        {
            Debug.Log("Not enough energy to consume.");
            // Optionally handle the consequences of not having enough energy
        }
    }

    // Function to deduct oxygen when consumed by the population
    public void ConsumeOxygen(int amount)
    {
        if (Oxygen >= amount)
        {
            Oxygen -= amount;
        }
        else
        {
            Debug.Log("Not enough oxygen to consume.");
            // Optionally handle the consequences of not having enough oxygen
        }
    }

    // Building properties
    public int FoodProductionPerBuilding = 3;
    public int EnergyProductionPerBuilding = 3;
    public int OxygenProductionPerBuilding = 2;



    // Function to spend resources for the population
    public void SpendResourcesForPopulation(int populationCount, int foodGenerated, int energyGenerated, int oxygenGenerated)
    {
        int totalResourceCost = populationCount * baseResourceDemand;

        // Deduct resources based on the total resource cost for the population
        SpendResources(totalResourceCost, totalResourceCost, totalResourceCost, totalResourceCost);

        // Increase resources based on the production of each building
        Food += foodGenerated;
        Energy += energyGenerated;
        Oxygen += oxygenGenerated;
    }


    // Function to handle population demands
    public void HandlePopulationDemands(int populationCount, int energyDemand, int oxygenDemand, int foodDemand, int mineralDemand)
    {
        int totalResourceDemand = populationCount * baseResourceDemand;

        // Check if the available resources are sufficient to meet the demands of the population
        if (Food < foodDemand)
        {
            // Implement logic to handle food shortage
            Debug.Log("Food shortage! Population is starving.");
            // Add code to handle the consequences of food shortage
        }

        if (Energy < energyDemand)
        {
            // Implement logic to handle energy shortage
            Debug.Log("Energy shortage! Population is facing power outages.");
            // Add code to handle the consequences of energy shortage
        }

        if (Oxygen < oxygenDemand)
        {
            // Implement logic to handle oxygen shortage
            Debug.Log("Oxygen shortage! Population is suffocating.");
            // Add code to handle the consequences of oxygen shortage
        }

        if (Minerals < mineralDemand)
        {
            // Implement logic to handle mineral shortage
            Debug.Log("Mineral shortage! Population is unable to build infrastructure.");
            // Add code to handle the consequences of mineral shortage
        }

    }
}
