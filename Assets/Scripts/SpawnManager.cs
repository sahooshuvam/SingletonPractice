using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
 
    public GameObject trashPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInformation;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//
            if (Physics.Raycast(ray.origin,ray.direction,out hitInformation))
            {
               GameObject temp = Instantiate(trashPrefab,hitInformation.point,Quaternion.identity);
               GameManager.Instance.AddTrashCans(temp);
                print(GameManager.Instance.TranshCan.Count);

            }
        }

        if (Input.GetMouseButtonDown(1))
        {

               // GameManager.Instance.RemoveTrashCans(GameManager.Instance.TranshCan);
                print(GameManager.Instance.TranshCan.Count);

            }
        }
    }

