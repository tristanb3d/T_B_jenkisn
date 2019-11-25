using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.Assertions;

namespace Tests
{
    public class SampleTests
    {
        private GameObject game;
        private GameObject game1;
        //public GameObject derp;
        public object otherGameObject { get; private set; }

        [UnitySetUp]
        public IEnumerator SetUp()
        {
            GameObject gamePrefab = Resources.Load<GameObject>("Prefabs/Game");
            game = Object.Instantiate(gamePrefab);
            yield return null;
        }
        [UnityTearDown]
        public IEnumerator TearDown()
        {
            Object.Destroy(game);
            yield return null;
        }


        [UnityTest]
        public IEnumerator PlayeMove()
        {
            // Get Access to PlayerMovement
            PlayerMovement player = game.GetComponentInChildren<PlayerMovement>();


            Vector3 oldPosition = player.transform.position;

            // A. Run the Player 'Move' function
            player.Move(Vector3.right * 10f);

            // B. Wait till the end of Frame
            yield return new WaitForEndOfFrame();

            Vector3 newPosition = player.transform.position;

            // C. Check if the Player's position indicates movement
            Assert.AreNotEqual(oldPosition, newPosition);
        }


        [UnityTest]
        public IEnumerator PlayeShooting()
        {

            PlayerShoot playershot = game.GetComponentInChildren<PlayerShoot>();



            if (playershot)
            {
                Debug.Log("shooting");
            }

            yield return new WaitForEndOfFrame();


            Assert.IsTrue(playershot);

        }

        [UnityTest]
        public IEnumerator PlayerShoot_ScoreAdded_Method()
        {
            PlayerShoot playerShoot = game.GetComponentInChildren<PlayerShoot>();

            // A. Store current score count
            int oldScore = playerShoot.scorecount;
            // B. Add 1 to Score Count
            playerShoot.scorecount++;

            yield return new WaitForEndOfFrame();

            // C. Check and see if new score is different to old score
            int newScore = playerShoot.scorecount;

            Assert.IsTrue(newScore != oldScore);
        }



        //[UnityTest]
        //public IEnumerator Enm_dead()
        //{

        //    PlayerShoot enmny = game.GetComponentInChildren<PlayerShoot> ();

        //     GameObject.FindWithTag("enm").GetComponentsInChildren<PlayerShoot>();


        //    if (enmny == null)
        //    {

        //        Debug.Log("enm_dead");

        //    }

        //    Assert.IsTrue(enmny = null);

        //}


        [UnityTest]
        public IEnumerator Playe_jump()
        {
            // Get Access to PlayerMovement
            PlayerMovement player = game.GetComponentInChildren<PlayerMovement>();


            Vector3 oldPosition = player.transform.position;

            // A. Run the Player 'Move' function
            player.Move(Vector3.up * 2f);

            // B. Wait till the end of Frame
            yield return new WaitForEndOfFrame();

            Vector3 newPosition = player.transform.position;

            // C. Check if the Player's position indicates movement
            Assert.AreNotEqual(oldPosition, newPosition);
        }


    }
}
