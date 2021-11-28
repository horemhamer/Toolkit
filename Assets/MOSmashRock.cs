using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOSmashRock : MonoBehaviour
{
    // Start is called before the first frame update    PlayerScript playerScript;
    RaycastHit raycastHit;
    PlayerScript playerScript;
    bool m_HitDetect;
    private void Start() {
        playerScript = this.GetComponent<PlayerScript>();
    }
 
   /* private void Update() {
        
         Ray rayo = new Ray(playerScript.GetTransformMOdel().position + Vector3.up,playerScript.GetTransformMOdel().forward);
          
        Debug.DrawRay(playerScript.GetTransformMOdel().position,playerScript.GetTransformMOdel().forward*1.5f,Color.red);
          if(Physics.Raycast(playerScript.GetTransformMOdel().position,playerScript.GetTransformMOdel().forward,out raycastHit,1.5f)){
            if(raycastHit.transform.tag=="smashrock" && Input.GetKeyDown(KeyCode.A)){
                  raycastHit.transform.gameObject.SetActive(false);
              }
          }
    }*/

    private void Update() {
         LayerMask layerMask = LayerMask.GetMask("SmashRock");
         Vector3 vector3 = new Vector3(0.5f,0.5f,0.5f);
        m_HitDetect = Physics.BoxCast(playerScript.GetTransformModel().transform.position,vector3,playerScript.GetTransformModel().forward, out raycastHit, 
        Quaternion.identity,1f,layerMask);  
        if(m_HitDetect){
            if(Input.GetKeyDown(KeyCode.A))
             raycastHit.transform.gameObject.SetActive(false);
        }
    }
}
