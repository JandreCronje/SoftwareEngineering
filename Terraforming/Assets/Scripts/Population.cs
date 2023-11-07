using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Population : MonoBehaviour
{
    public int currentPopulation;
    private int baseResourceDemand = 5; // Base resource demand for a single individual

    private ResourceGatheringScript resourceGatheringScript; // Reference to your resource management script

    // Start is called before the first frame update
    void Start()
    {
        resourceGatheringScript = GetComponent<ResourceGatheringScript>(); // Assuming ResourceGatheringScript is attached to the same GameObject
        currentPopulation = 0; // Starting population
        StartCoroutine(IncreasePopulation());
    }

    // Update is called once per frame
    void Update()
    {
        CheckResourceDemands();
    }

    IEnumerator IncreasePopulation()
    {
        while (true) // You can adjust the conditions for population growth as needed
        {
            yield return new WaitForSeconds(10f); // Adjust the time interval for population growth

            // Increase the population size
            currentPopulation++;

            // Update resource demands based on the current population
            UpdateResourceDemands();
        }
    }

    void UpdateResourceDemands()
    {
        // Adjust the resource demands based on the current population
        int foodDemand = currentPopulation / 5;
        int energyDemand = currentPopulation / 5;
        int oxygenDemand = currentPopulation / 5;
        int mineralDemand = currentPopulation / 5;

        // Call the resource management script to handle resource demands
        resourceGatheringScript.HandlePopulationDemands(foodDemand, energyDemand, oxygenDemand, mineralDemand);
    }

    void CheckResourceDemands()
    {
        // Check if there are enough resources to meet the demands of the population
        if (resourceGatheringScript.Food < baseResourceDemand)
        {
            // Handle shortage of food resources
            Debug.Log("Insufficient food resources. Population is starving.");
            // Implement logic to handle starvation or any other consequences
        }

        if (resourceGatheringScript.Energy < baseResourceDemand)
        {
            // Handle shortage of energy resources
            Debug.Log("Insufficient energy resources. Population is facing power outages.");
            // Implement logic to handle power outages or any other consequences
        }

        if (resourceGatheringScript.Oxygen < baseResourceDemand)
        {
            // Handle shortage of oxygen resources
            Debug.Log("Insufficient oxygen resources. Population is suffocating.");
            // Implement logic to handle oxygen shortages or any other consequences
        }

        if (resourceGatheringScript.Minerals < baseResourceDemand)
        {
            // Handle shortage of mineral resources
            Debug.Log("Insufficient mineral resources. Population is unable to build infrastructure.");
            // Implement logic to handle resource shortages or any other consequences
        }

        // You can add more checks and handle other resource shortages here based on your game's mechanics
    }

}
