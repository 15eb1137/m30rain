using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesBomb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject objBomb = (GameObject)Resources.Load("musicbox.bomb");

        //pink
        Instantiate(objBomb, new Vector3(-3.02f, 5.35f, 109.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 5.35f, 163.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 5.35f, 174.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 5.35f, 183.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 5.35f, 209.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 5.35f, 263.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 5.35f, 274.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-3.02f, 5.35f, 283.0f), Quaternion.identity);

        //green
        Instantiate(objBomb, new Vector3(-0.99f, 5.35f, 305.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-0.99f, 5.35f, 312.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-0.99f, 5.35f, 331.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-0.99f, 5.35f, 339.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-0.99f, 5.35f, 347.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(-0.99f, 5.35f, 369.0f), Quaternion.identity);

        //blue
        Instantiate(objBomb, new Vector3(1.01f, 5.35f, 124.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 5.35f, 144.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 5.35f, 154.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 5.35f, 176.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 5.35f, 184.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 5.35f, 224.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 5.35f, 244.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 5.35f, 254.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(1.01f, 5.35f, 276.5f), Quaternion.identity);

        //orange
        Instantiate(objBomb, new Vector3(3.05f, 5.35f, 117.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 5.35f, 122.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 5.35f, 126.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 5.35f, 141.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 5.35f, 150.0f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 5.35f, 163.5f), Quaternion.identity);
        Instantiate(objBomb, new Vector3(3.05f, 5.35f, 189.0f), Quaternion.identity);
    }
}
