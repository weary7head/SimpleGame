using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Circle
{
    public class Circle
    {
        private Rigidbody _rigidBody;
        public float Speed { get; set; }
        public bool IsAlive { get; set; }
        public static int Score { get; set; }
        public Circle()
        {

        }

        public Circle(float speed, Rigidbody rigidbody, bool isAlive)
        {
            this._rigidBody= rigidbody;
            this.Speed = speed;
            this.IsAlive = isAlive;
            Score = 0;
        }

        public void Movement(Vector3 vector3)
        {
            _rigidBody.AddForce(vector3 * Speed, ForceMode.VelocityChange);
        }
    }
}
