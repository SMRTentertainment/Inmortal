using System;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    //TODO: Raycast2D para comprobar si el mouse está tocando una plataforma para poder spawnear
    
    public GameObject platformPrefab;
    public float spawnHeight = 0f;
    public float distanceBetweenPlatforms = 0.000001f;
    public float spawnInterval = 0.000000000001f;
    
    private bool isSpawning = false;
    
    
    public LayerMask platformLayer;
    
    private float spawnTimer = 0f;
    private Vector3 lastSpawnPosition;
    private bool IsSpawning = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detectar si el botón izquierdo del mouse ha sido presionado¿
        {
            IsSpawning = true;
            lastSpawnPosition = GetMouseWorldPosition();
            SpawnPlatform(lastSpawnPosition);
        }

        if (Input.GetMouseButtonUp(0))
        {
            IsSpawning = false;
        }

        if (IsSpawning)
        {
            Vector3 currentMousePos = GetMouseWorldPosition();
            // Solo spawnea si el mouse se movió lo suficiente desde la última plataforma
            if (Vector3.Distance(currentMousePos, lastSpawnPosition) >= distanceBetweenPlatforms)
            {
                SpawnPlatform(currentMousePos);
                lastSpawnPosition = currentMousePos;
            }
        }
    }

    Vector3 GetMouseWorldPosition()
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            return new Vector3(mousePosition.x, mousePosition.y, spawnHeight); // Ajustá Z o Y según tu escena
        }

        void SpawnPlatform(Vector3 position)
        {
            Instantiate(platformPrefab, position, Quaternion.identity);
        }
    }

    