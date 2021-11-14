using Microsoft.VisualStudio.TestTools.UnitTesting;
using Atelier3;
namespace Atelier3.Test
{
    [TestClass]
    public class TransformTest
    {
        [TestMethod]
        public void TestHeurePile(){
            Transform.Dico();
            int i = 1;
            Assert.AreEqual("Il est " + Transform.dico[i] + " heure", Transform.Convert(i, 0));
        }

        [TestMethod]
        public void TestHeureAprMidi(){
           Transform.Dico();
            int i = 14;
            int y = 2;
            Assert.AreEqual("Il est " + Transform.dico[y] + " heure", Transform.Convert(i, 0));
        }

        [TestMethod]
        public void TestMotHeure(){
            Transform.Dico();
            Assert.AreEqual("Il est " + Transform.dico[12], Transform.Convert(12, 0));
        }
        [TestMethod]
        public void TestMotHeure2(){
           Transform.Dico();
            Assert.AreEqual("Il est " + Transform.dico[3] + " heure", Transform.Convert(3, 0)); 
        }

        [TestMethod]
        public void TestParMinuteCinqParCinq(){
           Transform.Dico();
            Assert.AreEqual("Il est " + Transform.dico[3] + " heure " + "vingt" , Transform.Convert(3, 22)); 
        }

        [TestMethod]
        public void TestMoinsMinute(){
           Transform.Dico();
            Assert.AreEqual("Il est " + Transform.dico[4] + " heure moins vingt-cinq du matin", Transform.Convert(3, 35)); 
        }

        [TestMethod]
        public void TestDeuxMoinsMinute(){
           Transform.Dico();
            Assert.AreEqual("Il est " + Transform.dico[7] + " heure moins quart de l'après-midi", Transform.Convert(18, 45)); 
        }

        
    }
}
