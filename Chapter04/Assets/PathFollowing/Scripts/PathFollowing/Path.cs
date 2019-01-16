using UnityEngine;

public class Path: MonoBehaviour
{
    [SerializeField]
    private Vector3[] waypoints;

    public bool isDebug = true;
    public float radius = 2.0f;

    public float PathLength {
        get { return waypoints.Length; }
    }
    
    public Vector3 GetPoint(int index)
    {
        return waypoints[index];
    }
    
    private void OnDrawGizmosSelected()
    {
        if (!isDebug) {
            return;
        }
        Gizmos.color = Color.green;
        Gizmos.DrawCube(this.transform.position, Vector3.one * 1.1f);
        for (int i = 0; i < waypoints.Length; i++)
        {
            if (i + 1 < waypoints.Length)
            {
                //Debug.DrawLine(waypoints[i], waypoints[i + 1], Color.red);
                // Debug.DrawLine dont disappear after they have drawed.

                Gizmos.DrawLine(waypoints[i], waypoints[i + 1]/*, Color.red*/);
            }
        }
    }
}