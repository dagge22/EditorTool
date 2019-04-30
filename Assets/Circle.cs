using UnityEngine;

public class Circle : MonoBehaviour
{
    public int vertexes = 40;
    public float radius;

    LineRenderer renderer;

    void Start()
    {
        renderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        CreateCircle();
    }

    void CreateCircle()
    {
        renderer.widthMultiplier = 0.1f;

        float deltaTheta = (2f * Mathf.PI) / vertexes;
        float theta = 0f;

        renderer.positionCount = vertexes + 1;

        for (int i = 0; i < renderer.positionCount; i++)
        {
            Vector3 pos = new Vector3(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta), 0f);
            renderer.SetPosition(i, pos);

            theta += deltaTheta;
        }
    }
}
