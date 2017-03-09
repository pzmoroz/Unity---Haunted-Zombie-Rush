using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Rock : Object
    {

        [SerializeField] private Vector3 topPosition;
        [SerializeField] private Vector3 bottomPosition;
        [SerializeField] private float speed;


        // Use this for initialization
        void Start () {
            StartCoroutine(Move(bottomPosition));		
        }

        protected override void Update()
        {
            base.Update();
        }

        IEnumerator Move(Vector3 target)
        {
            while(Mathf.Abs((target - transform.localPosition).y) > 0.2f)
            {
                Vector3 direction = target.y == topPosition.y ? Vector3.up : Vector3.down;

                transform.localPosition += direction * Time.deltaTime * speed;

                yield return null;
            }

            print("Reached the target");

            yield return new WaitForSeconds(0.1f);

            Vector3 newTarget = target.y == topPosition.y ? bottomPosition : topPosition;

            StartCoroutine(Move(newTarget));
        }
    }
}
