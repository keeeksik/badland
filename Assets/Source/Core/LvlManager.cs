using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace Core
{

    public class LvlManager : MonoBehaviour
    {
        [SerializeField] private GameObject [] lvlPrefabs;
        [SerializeField] private GameObject startPrefab;
        [SerializeField] private GameObject finishPrefab;
        [SerializeField] Vector2 startPosition;
        [SerializeField] private GameObject player;
        private int lvlindex;
        [SerializeField] private float offsetX;
        private Vector2 previuosPosition;

        void Start()
        {
            if (PlayerPrefs.GetInt("lvl_index") <= 0)
            {
                lvlindex = 1;
                PlayerPrefs.SetInt("lvl_index", lvlindex);
            
            }
            else
            {
                lvlindex = PlayerPrefs.GetInt("lvl_index");
            }

            Instantiate(startPrefab, startPosition, Quaternion.identity);
            player.transform.position = new Vector2 (startPosition.x - 12, startPosition.y - 7);
            previuosPosition = startPosition;
            SpawnRandomLvl();
            previuosPosition = new Vector2(previuosPosition.x + offsetX, previuosPosition.y);
            Instantiate(finishPrefab, previuosPosition, Quaternion.identity);
        }


        private void SpawnRandomLvl()
        {
            for (int i = 0; i < lvlindex; i++)
            {
                int random = UnityEngine.Random.Range(0, lvlPrefabs.Length);
                previuosPosition = new Vector2 (previuosPosition.x + offsetX, previuosPosition.y);
                Instantiate(lvlPrefabs[random], previuosPosition, Quaternion.identity);
            }
        }

    }
}
