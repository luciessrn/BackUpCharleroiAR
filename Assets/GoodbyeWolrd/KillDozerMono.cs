using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lucie
{
    public class KillDozerMono : MonoBehaviour
    {
        /// <summary>
        /// This is the rotation of the kill Dozer in angle left right
        /// </summary>
        [Tooltip("This rotation is in angle around Y axis")]
        public float m_rotationLeftRight = 90f;
        [Tooltip("This is speed in meter to go forward")]
        public float m_frontalSpeed = 10f;
        [Tooltip("This is speed in meter to go backward")]
        public float m_backSpeed = 5f;

        [Range(-1,1)]
        [SerializeField]
        public float m_rotateLeftRightPercent;

        [Range(-1,1)]
        [SerializeField]
        public float m_moveFrontBackPercent;

        
        void Start()
        {
            
        }

        public Transform m_whatToMove;

        public void SetRotateLeftRightPercent(float percent11)
        {
            if(percent11>1)
                percent11 = 1;
            if(percent11<-1)
                percent11 = -1;
            m_rotateLeftRightPercent = percent11;
        }

        public void SetMoveBackForwardPercent(float percent11)
        {
            percent11=Mathf.Clamp(percent11,-1,1);
            m_moveFrontBackPercent = percent11;
        }
        void Update()
        {
            //Rotation
            float rotation = m_rotationLeftRight
                * m_rotateLeftRightPercent;
            m_whatToMove.Rotate(0, rotation * Time.deltaTime, 0);
            //Translation
            float speed = m_moveFrontBackPercent >
                0 ? m_frontalSpeed : m_backSpeed;
            m_whatToMove.Translate(0,0,m_moveFrontBackPercent*speed*Time.deltaTime);
        }
    }
}
