using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFSM : MonoBehaviour
{
    public enum EnemyState { GoToBase, ChasePlayer, ReadyToRun}
    public EnemyState currentState;

    public Sight sightSensor;
    public Transform baseTransform;
    public float baseAttackDistance;

    private NavMeshAgent agent;
    private float timeInReadyToRun = 0f;
    private float readyToRunDuration = 2f;

    private void Awake()
    {
        baseTransform = GameObject.Find("Base").transform;
        agent = GetComponentInParent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desireDirection = agent.velocity.normalized;
        if(desireDirection != Vector3.zero)
        {
            
            Quaternion desireRotation = Quaternion.LookRotation(desireDirection, Vector3.up) * Quaternion.Euler(-90, 0, 0);
            agent.transform.rotation = desireRotation;
            
            float offsetY = 0.7f;
            Vector3 newPosition = new Vector3(agent.transform.position.x, agent.transform.position.y + offsetY, agent.transform.position.z);
            agent.transform.position = newPosition;
        }
        if(currentState == EnemyState.GoToBase) { GoToBase(); }
        else if(currentState == EnemyState.ChasePlayer) { ChasePlayer(); }
        else { ReadyToRun(); }
    }

    void GoToBase()
    {
        agent.isStopped = false;

        float chaseSpeed = 2.0f;
        agent.speed = chaseSpeed;

        agent.SetDestination(baseTransform.position);

        if(sightSensor.detectedObject != null)
        {
            currentState = EnemyState.ReadyToRun;
        }

        timeInReadyToRun = Time.time;
        float distanceToBase = Vector3.Distance(
            transform.position, baseTransform.position);

        if(distanceToBase < baseAttackDistance)
        {
            currentState = EnemyState.GoToBase;
        }
    }

    public float playerAttackDistance;
    void ChasePlayer()
    {
        agent.isStopped = false;
        
        if(sightSensor.detectedObject == null)
        {
            currentState = EnemyState.GoToBase;
            return;
        }
        float chaseSpeed = 12.0f;
        agent.speed = chaseSpeed;

        agent.SetDestination(sightSensor.detectedObject.transform.position);

        float distanceToPlayer = Vector3.Distance(transform.position,
            sightSensor.detectedObject.transform.position);

        if(distanceToPlayer <= playerAttackDistance)
        {
            currentState = EnemyState.ReadyToRun;
        }
    }

    void ReadyToRun()
    {
        
        float chaseSpeed = 0.1f;
        agent.speed = chaseSpeed;

        float elapsedTimeInReadyToRun = Time.time - timeInReadyToRun;
        if(elapsedTimeInReadyToRun >= readyToRunDuration)
        {
            currentState = EnemyState.ChasePlayer;
        }

        if(sightSensor.detectedObject == null)
        {
            currentState = EnemyState.GoToBase;
        }

        // 살짝 수직 이동
        float verticalSpeed = 6.0f; // 수직 이동 속도
        float verticalAmount = 0.2f; // 수직 이동 거리
        float verticalOffset = Mathf.Sin(Time.time * verticalSpeed) * verticalAmount;

        // Translate 함수를 사용하여 살짝 수직 이동
        agent.transform.Translate(new Vector3(0.0f, 0.0f, -verticalOffset));
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, playerAttackDistance);

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, baseAttackDistance);
    }
}
