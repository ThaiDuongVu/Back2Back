using UnityEngine;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour
{
    #region Singleton

    private static LevelGenerator instance;
    public static LevelGenerator Instance
    {
        get
        {
            if (instance == null) instance = FindObjectOfType<LevelGenerator>();

            return instance;
        }
    }

    #endregion
    public Transform[] levelUnits;
    public Transform[] levelConnectors;

    private Vector3 lastPosition = Vector3.zero;
    public Transform[] tokenUnits;

    private float gapBetweenUnits = 70.7f;

    private List<Transform> previousUnits = new List<Transform>();
    public Transform connectorBorder;

    /// <summary>
    /// Generate next piece of level.
    /// </summary>
    public void GenerateNext()
    {
        DestroyPrevious();

        previousUnits.Add(SpawnConnector());
        previousUnits.Add(SpawnUnit());
        previousUnits.Add(SpawnTokens());
        previousUnits.Add(SpawnTokens());
        previousUnits.Add(SpawnTokens());
    }

    /// <summary>
    /// Destroy previous level to save on resources.
    /// </summary>
    public void DestroyPrevious()
    {
        if (previousUnits.Count < 10) return;

        for (int i = 0; i < 5; i++)
            Destroy(previousUnits[i].gameObject);

        for (int _ = 0; _ < 5; _++)
            previousUnits.RemoveAt(0);

        Instantiate(connectorBorder, previousUnits[0].position - new Vector3(35.85f, 0f, 35.85f), connectorBorder.transform.rotation);
    }

    /// <summary>
    /// Spawn a level connector.
    /// </summary>
    public Transform SpawnConnector()
    {
        lastPosition = new Vector3(lastPosition.x + gapBetweenUnits, 0f, lastPosition.z + gapBetweenUnits);
        return Instantiate(levelConnectors[Random.Range(0, levelConnectors.Length)], lastPosition, levelConnectors[0].transform.rotation);
    }

    /// <summary>
    /// Spawn a level unit.
    /// </summary>
    public Transform SpawnUnit()
    {
        lastPosition = new Vector3(lastPosition.x + gapBetweenUnits, 0f, lastPosition.z + gapBetweenUnits);
        return Instantiate(levelUnits[Random.Range(0, levelUnits.Length)], lastPosition, levelUnits[0].transform.rotation);
    }

    /// <summary>
    /// Spawn tokens at random positions.
    /// </summary>
    public Transform SpawnTokens()
    {
        Vector3 spawnPosition = lastPosition + new Vector3(Random.Range(-25f, 25f), 2f, Random.Range(-25f, 25f));
        return Instantiate(tokenUnits[Random.Range(0, tokenUnits.Length)], spawnPosition, tokenUnits[0].transform.rotation);
    }
}