using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleighMove : MonoBehaviour
{
    private bool isPlay = false;
    private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlay)
            Move();
    }
    void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (rigid.velocity.z <= 20)
            rigid.velocity += transform.forward * v;
        //rigid.MoveRotation(Quaternion.Euler(0, h * 3, 0));
        transform.Rotate(new Vector3(0, h, 0));
    }
    public void StartRace() { isPlay = true; }
    public void Finish() { StartCoroutine(finish()); }
    IEnumerator finish()
    {
        isPlay = false;
        while (rigid.velocity.z > 0)
        {
            yield return new WaitForSeconds(0.1f);
            rigid.velocity -= transform.forward * 0.1f;
        }
    }
}
