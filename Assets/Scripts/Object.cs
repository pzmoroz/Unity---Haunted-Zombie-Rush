﻿using UnityEngine;

namespace Assets.Scripts
{
    public class Object : MonoBehaviour
    {

        [SerializeField] private float objectSpeed = 1;
        [SerializeField] private float resetPosition = -2f;
        [SerializeField] private float startPosition = 98f;

        // Use this for initialization
        void Start () {
		
        }
	
        // Update is called once per frame
        protected virtual void Update () {
            transform.Translate(Vector3.left * (objectSpeed * Time.deltaTime));

            if (transform.localPosition.x < resetPosition)
            {
                Vector3 newPos = new Vector3(startPosition, transform.position.y, transform.position.z);
                transform.position = newPos;
            }
        }
    }
}
