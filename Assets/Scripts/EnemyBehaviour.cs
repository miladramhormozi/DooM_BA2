using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        public enum EnemyState
            { IDLE, PATROL, APPROACH, ATTACK, TAKEDAMAGE, DEAD }
        public EnemyState enemyState;
        bool PlayerInSight;
        private void private void Start() 
        {
            enemyState = EnemyState.IDLE;
        }

        private void Update()
        {
            switch(enemyState)
            {
                case EnemyState.IDLE:
                    //do something
                    break;
                case EnemyState.APPROACH:
                    //do something
                    break;
                default:
                    break;
            }
        }

        bool PlayerInSight()
        {
            Ray ray = new Ray(transform.position, Camera.main.transform.position - transform.position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 25f))
            {
                if (hit.collider.tag == "Player")
                {
                    Debug.DrawRay(transform.position)
                    Camera.main.transform.position - transform.position,

                    return true;
                }
            }
            return false;
        }

    }
}
