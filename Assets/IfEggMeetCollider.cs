using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfEggMeetCollider : MonoBehaviour
{
    public class ball : MonoBehaviour
    {
        Vector3 MovePos; // ¿Ãµø∫§≈Õ
        public float _speed = 4f;

        void Start()
        {
            MovePos = new Vector2(1f, 1f).normalized;
        }

        void Update()
        {
            transform.position += MovePos * _speed * Time.deltaTime;
        }
    }
}
