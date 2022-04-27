using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionBloc : MonoBehaviour
{

    public GameObject bloc;
    public GameObject player;

void OnCollisionEnter(Collision col)
{
    if (col.gameObject.tag == "bloc_sol")
    {
    player.transform.position= bloc.transform.position;
      
    }
}
    
}
