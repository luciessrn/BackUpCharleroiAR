using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lucie
{
    public class FollowExactlyTargetMono : MonoBehaviour
    {

        public Transform m_whatToMove;
        public Transform m_whatToFollow;
   

    // Update is called once per frame
    void Update()
        {
            m_whatToMove.position= m_whatToFollow.position;
            m_whatToMove.rotation =m_whatToFollow.rotation;
        }
    }
}