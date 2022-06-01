using UnityEngine;

public class Explosion : MonoBehaviour { 
    public int cubesPerAxis = 8;
    public float force = 300f;
    public float radius = 2f;

    public void Explode(GameObject Object) {
        for (int x = 0; x < cubesPerAxis; x++) {
            for (int y = 0; y < cubesPerAxis; y++) {
                for (int z = 0; z < cubesPerAxis; z++) {
                    CreateCube(new Vector3(x, y, z),Object);
                }
            }
        }

        Destroy(gameObject);
    }

    void CreateCube(Vector3 coordinates,GameObject Object) {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        Renderer rd = cube.GetComponent<Renderer>();
        rd.material = GetComponent<Renderer>().material;

        cube.transform.localScale = Object.transform.localScale / cubesPerAxis;

        Vector3 firstCube = Object.transform.position - Object.transform.localScale / 2 + cube.transform.localScale / 2;
        cube.transform.position = firstCube + Vector3.Scale(coordinates, cube.transform.localScale);

        Rigidbody rb = cube.AddComponent<Rigidbody>();
        rb.AddExplosionForce(force, Object.transform.position, radius);
        Destroy(cube, 1f);
    }
}