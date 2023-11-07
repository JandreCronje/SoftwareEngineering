using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerraformingScript : MonoBehaviour
{
    public float terraformingProgress;


    public ResourceGatheringScript resourceGatheringScript; // Reference to the ResourceGatheringScript
    public BuildingConstructionScript buildingConstructionScript; // Reference to the BuildingConstructionScript

    // Function to update terraforming progress based on building effects
    public void UpdateTerraformingProgress()
    {
        // Implement logic to update terraforming progress
    }

    // Function to check for win condition
    public bool CheckWinCondition()
    {
        return terraformingProgress >= 100;
    }

    // Assign the ResourceGatheringScript and BuildingConstructionScript references when the script starts
    void Start()
    {
        resourceGatheringScript = FindObjectOfType<ResourceGatheringScript>();
        if (resourceGatheringScript == null)
        {
            Debug.LogError("ResourceGatheringScript not found in the scene.");
        }

        buildingConstructionScript = FindObjectOfType<BuildingConstructionScript>();
        if (buildingConstructionScript == null)
        {
            Debug.LogError("BuildingConstructionScript not found in the scene.");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left click
        {
            // Call the function to initiate terraforming
            InitiateTerraforming();
        }

        // Allowing the player to press number buttons to build a building
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buildingConstructionScript.ConstructShelter(2,2,0,0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buildingConstructionScript.ConstructEnergyGenerator(0, 4, 2, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buildingConstructionScript.ConstructBiodiversityFarm(5, 0, 1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            buildingConstructionScript.ConstructAdvancedLaboratory(1, 0, 0,6);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            buildingConstructionScript.ConstructBioDome(3, 4, 2, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            buildingConstructionScript.ConstructOxygenFarm(0, 0, 0, 4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            buildingConstructionScript.ConstructFoodStorage(3, 0, 0, 2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            buildingConstructionScript.ConstructLiveStockFarm(0, 2, 0, 0);
        }
    }

    // Function to handle the terraforming process
    private void InitiateTerraforming()
    {
        // Check if the terraforming progress is not yet 100
        if (terraformingProgress < 100)
        {
            // Implement logic to increase terraforming progress when the user left-clicks
            Debug.Log("Terraforming percentage: " + terraformingProgress + "%");
            terraformingProgress += 1; // You can change this value based on your desired progression rate
            UpdateTerraformingProgress(); // Call the function to update the terraforming progress

            // Check if the terraforming progress is a multiple of a certain value (indicating completion of a terraform)
            if (terraformingProgress % 10 == 0) // Adjust the value as needed
            {
                // Implement logic for building construction and resource gain
                Debug.Log("Resource found");
                GainRandomResource();
            }
        }
        else
        {
            // Reset the terraforming progress back to 0 when it reaches 100
            terraformingProgress = 0;
            Debug.Log("Terraforming progress reset to 0.");
        }

        // Check for win condition
        if (CheckWinCondition())
        {
            // Implement logic for the win condition and victory screen
            Debug.Log("Congratulations! You have successfully terraformed the planet!");
        }
    }


    // Function to gain a random resource
    private void GainRandomResource()
    {
        // Implement logic to gain a random resource
        // You can use the ResourceGatheringScript here to handle resource gain
        int randomResource = Random.Range(1, 5); // Generates a random resource type between 1 and 3 (inclusive)
        switch (randomResource)
        {
            case 1:
                resourceGatheringScript.Food += 1; // Increase resource type 1
                break;
            case 2:
                resourceGatheringScript.Energy += 1; // Increase resource type 2
                break;
            case 3:
                resourceGatheringScript.Oxygen += 1; // Increase resource type 3
                break;
            case 4:
                resourceGatheringScript.Minerals += 1; // Increase resource type 3
                break;
            default:
                break;
        }
    }
}
