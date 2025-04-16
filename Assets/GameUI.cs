// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GmaeUI : MonoBehaviour
// {   
//     public static GmaeUI Intance { get; set; }

//     [SerializeField] private Animator menuAnimator;
//     // Start is called before the first frame update
//     private void Awale(){
//         Intance = this;
//     }
//     //Button
//     public void OnlocalGameButton(){
//         menuAnimator.SetTrigger("IngameMenu");
//     }
//     public void OnOnlineGameButton(){
//         menuAnimator.SetTrigger("OnlineMenu");
//     }
//     public void OnOnlineHostButton(){
//         menuAnimator.SetTrigger("HostMenu");
//     }
//     public void OnOnlineConnectButton(){
//         Debug.Log("OnOnlineConnectButton");
//     }
//     public void OnOnlineBackButton(){
//         menuAnimator.SetTrigger("StartMenu");
//     }
//     public void OnHostBackButton(){
//         menuAnimator.SetTrigger("OnlineMenu");
//     }
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
