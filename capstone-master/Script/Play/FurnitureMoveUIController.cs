using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FurnitureMoveUIController : MonoBehaviour
{
    CameraController m_camera;
    bool m_isDrag = false;
    Vector3 preObjPos;
    Ray m_ray; //광선을 나타내는 변수

    RaycastHit m_rayHit; //충돌을 나타내는 변수
    RaycastHit hit_L; // 벽에 부딪히는 충돌 나타내는 변수
    RaycastHit hit_R; // 벽에 부딪히는 충돌 나타내는 변수
    RaycastHit hit_U; // 벽에 부딪히는 충돌 나타내는 변수
    RaycastHit hit_D; // 벽에 부딪히는 충돌 나타내는 변수

    public void PD()
    {
        m_isDrag = true;
        m_camera.enabled = false;
    }

    public void PU()
    {
        m_isDrag = false;
        m_camera.enabled = true;

    }

    public void Init()
    {
        m_isDrag = false;
        m_camera.enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        m_camera = Camera.main.GetComponent<CameraController>();
        m_isDrag = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (m_isDrag)
        {
            m_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            var collidercenterpos = gameObject.transform.parent.GetComponent<BoxCollider>().center;
            var colliderglobalpos = gameObject.transform.parent.transform.TransformPoint(collidercenterpos);
            var furpos = gameObject.transform.parent.position;

            var furtransform = gameObject.transform.parent;
            var collidersize = gameObject.transform.parent.GetComponent<BoxCollider>().size;


            //레이를 쏘는 메소드 m_ray의 위치부터, 1키로 정도 광선을 쏠거고 hit된 결과는 m_rayHit에 담아서줘라 
            //RayCast는 반환값이 불린이다.
            if (Physics.Raycast(m_ray, out m_rayHit, 1000f, 1 << LayerMask.NameToLayer("Ground")))
            {
                gameObject.transform.parent.position = new UnityEngine.Vector3(m_rayHit.point.x, m_rayHit.point.y, m_rayHit.point.z) - new UnityEngine.Vector3((colliderglobalpos - furpos).x, 0, (colliderglobalpos - furpos).z);
            }

            /*
            if (preObjPos != null)
            {
                Debug.DrawRay(colliderglobalpos, -(preObjPos - furpos) * (gameObject.transform.parent.GetComponent<BoxCollider>().size.x), Color.red, 1f);

                if (Physics.Raycast(collidercenterpos, -(preObjPos - furpos), out hit, gameObject.transform.parent.GetComponent<BoxCollider>().size.x, 1 << LayerMask.NameToLayer("Wall")))
                {
                    Debug.Log("부딪혔음!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    gameObject.transform.parent.position = new Vector3(preObjPos.x, preObjPos.y, preObjPos.z);

                }
            }
            preObjPos = furpos;
            */
            /*
            Debug.DrawRay(colliderglobalpos, -furtransform.right * (collidersize.x / 2 + 0.2f), Color.red, 1f);
            Debug.DrawRay(colliderglobalpos, furtransform.right * (collidersize.x / 2 + 0.2f), Color.red, 1f);
            Debug.DrawRay(colliderglobalpos, furtransform.forward * (collidersize.z / 2 + 0.2f), Color.red, 1f);
            Debug.DrawRay(colliderglobalpos, -furtransform.forward * (collidersize.z / 2 + 0.2f), Color.red, 1f);

            if (Input.GetKey(KeyCode.V))
            {
                if (Physics.Raycast(colliderglobalpos, -furtransform.right, out hit_L, collidersize.x / 2, 1 << LayerMask.NameToLayer("Wall")))    //왼쪽
                {
                    gameObject.transform.parent.position = new UnityEngine.Vector3(hit_L.point.x, furpos.y, furpos.z) + new UnityEngine.Vector3((collidersize).x / 2, 0, 0);
                }
                if (Physics.Raycast(colliderglobalpos, furtransform.right, out hit_R, collidersize.x / 2, 1 << LayerMask.NameToLayer("Wall")))    //오른쪽
                {
                    gameObject.transform.parent.position = new UnityEngine.Vector3(hit_R.point.x, furpos.y, furpos.z) - new UnityEngine.Vector3((collidersize).x / 2, 0, 0);
                }
                if (Physics.Raycast(colliderglobalpos, furtransform.forward, out hit_U, collidersize.z / 2, 1 << LayerMask.NameToLayer("Wall")))    //위
                {
                    gameObject.transform.parent.position = new UnityEngine.Vector3(furpos.x, furpos.y, hit_U.point.z) - new UnityEngine.Vector3((collidersize).z / 2, 0, 0);
                }
                if (Physics.Raycast(colliderglobalpos, -furtransform.forward, out hit_D, collidersize.z / 2, 1 << LayerMask.NameToLayer("Wall")))    //아래
                {
                    gameObject.transform.parent.position = new UnityEngine.Vector3(furpos.x, furpos.y, hit_D.point.z) + new UnityEngine.Vector3((collidersize).z / 2, 0, 0);
                }
            }
            
           */
        }
    }
}