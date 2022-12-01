using Calidad20222.web.Models;
using Calidad20222.web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calidad20222Test
{
    public class PokerServisTest
    {
        [Test]
        public void pokeTest1() {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 2, Palo = "COCO" };
            var c2 = new Carta { Numero = 1, Palo = "COCO" };
            var c3 = new Carta { Numero = 11, Palo = "COCO" };
            var c4 = new Carta { Numero = 12, Palo = "COCO" };
            var c5 = new Carta { Numero = 10, Palo = "COCO" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("COLOR", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest2()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 1, Palo = "ESPADA" };
            var c2 = new Carta { Numero = 10, Palo = "ESPADA" };
            var c3 = new Carta { Numero = 5, Palo = "ESPADA" };
            var c4 = new Carta { Numero = 8, Palo = "ESPADA" };
            var c5 = new Carta { Numero = 3, Palo = "ESPADA" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.That(cards.GetJugada(card), Is.EqualTo("COLOR"));
        }
        [Test]
        public void pokeTest3()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 2, Palo = "TREBOL" };
            var c2 = new Carta { Numero = 13, Palo = "TREBOL" };
            var c3 = new Carta { Numero = 6, Palo = "TREBOL" };
            var c4 = new Carta { Numero = 10, Palo = "TREBOL" };
            var c5 = new Carta { Numero = 11, Palo = "TREBOL" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("COLOR", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest4()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 2, Palo = "CORAZON" };
            var c2 = new Carta { Numero = 13, Palo = "CORAZON" };
            var c3 = new Carta { Numero = 6, Palo = "CORAZON" };
            var c4 = new Carta { Numero = 10, Palo = "CORAZON" };
            var c5 = new Carta { Numero = 11, Palo = "CORAZON" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.That(cards.GetJugada(card), Is.EqualTo("COLOR"));
        }
        [Test]
        public void pokeTest5()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 1, Palo = "CORAZON" };
            var c2 = new Carta { Numero = 1, Palo = "TREBOL" };
            var c3 = new Carta { Numero = 8, Palo = "CORAZON" };
            var c4 = new Carta { Numero = 8, Palo = "ESPADA" };
            var c5 = new Carta { Numero = 9, Palo = "COCO" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.That(cards.GetJugada(card), Is.EqualTo("DOBLE PAREJA"));
        }
        [Test]
        public void pokeTest6()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 4, Palo = "COCO" };
            var c2 = new Carta { Numero = 4, Palo = "TREBOL" };
            var c3 = new Carta { Numero = 11, Palo = "TREBOL" };
            var c4 = new Carta { Numero = 5, Palo = "ESPADA" };
            var c5 = new Carta { Numero = 4, Palo = "COCO" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("TRIO", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest7()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 3, Palo = "COCO" };
            var c2 = new Carta { Numero = 2, Palo = "COCO" };
            var c3 = new Carta { Numero = 1, Palo = "CORAZON" };
            var c4 = new Carta { Numero = 2, Palo = "CORAZON" };
            var c5 = new Carta { Numero = 3, Palo = "CORAZON" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("DOBLE PAREJA", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest8()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 5, Palo = "TREBOL" };
            var c2 = new Carta { Numero = 6, Palo = "COCO" };
            var c3 = new Carta { Numero = 7, Palo = "TREBOL" };
            var c4 = new Carta { Numero = 5, Palo = "TREBOL" };
            var c5 = new Carta { Numero = 6, Palo = "CORAZON" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("DOBLE PAREJA", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest9()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 5, Palo = "TREBOL" };
            var c2 = new Carta { Numero = 6, Palo = "CORAZON" };
            var c3 = new Carta { Numero = 7, Palo = "CORAZON" };
            var c4 = new Carta { Numero = 5, Palo = "COCO" };
            var c5 = new Carta { Numero = 6, Palo = "CORAZON" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("DOBLE PAREJA", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest10()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 5, Palo = "ESPADA" };
            var c2 = new Carta { Numero = 6, Palo = "CORAZON" };
            var c3 = new Carta { Numero = 7, Palo = "ESPADA" };
            var c4 = new Carta { Numero = 5, Palo = "COCO" };
            var c5 = new Carta { Numero = 6, Palo = "ESPADA" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("DOBLE PAREJA", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest11()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 1, Palo = "ESPADA" };
            var c2 = new Carta { Numero = 5, Palo = "ESPADA" };
            var c3 = new Carta { Numero = 6, Palo = "ESPADA" };
            var c4 = new Carta { Numero = 8, Palo = "COCO" };
            var c5 = new Carta { Numero = 9, Palo = "ESPADA" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("CARTA MAYOR", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest13()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 10, Palo = "CORAZON" };
            var c2 = new Carta { Numero = 11, Palo = "ESPADA" };
            var c3 = new Carta { Numero = 12, Palo = "ESPADA" };
            var c4 = new Carta { Numero = 13, Palo = "COCO" };
            var c5 = new Carta { Numero = 12, Palo = "CORAZON" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("DOBLE", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest14()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 1, Palo = "COCO" };
            var c2 = new Carta { Numero = 11, Palo = "ESPADA" };
            var c3 = new Carta { Numero = 12, Palo = "TREBOL" };
            var c4 = new Carta { Numero = 1, Palo = "COCO" };
            var c5 = new Carta { Numero = 1, Palo = "CORAZON" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("TRIO", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest15()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 10, Palo = "COCO" };
            var c2 = new Carta { Numero = 11, Palo = "ESPADA" };
            var c3 = new Carta { Numero = 12, Palo = "TREBOL" };
            var c4 = new Carta { Numero = 5, Palo = "ESPADA" };
            var c5 = new Carta { Numero = 1, Palo = "CORAZON" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("CARTA MAYOR", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest16()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 1, Palo = "COCO" };
            var c2 = new Carta { Numero = 11, Palo = "ESPADA" };
            var c3 = new Carta { Numero = 7, Palo = "COCO" };
            var c4 = new Carta { Numero = 9, Palo = "ESPADA" };
            var c5 = new Carta { Numero = 1, Palo = "COCO" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("DOBLE", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest17()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 10, Palo = "TREBOL" };
            var c2 = new Carta { Numero = 11, Palo = "ESPADA" };
            var c3 = new Carta { Numero = 7, Palo = "COCO" };
            var c4 = new Carta { Numero = 9, Palo = "ESPADA" };
            var c5 = new Carta { Numero = 12, Palo = "TREBOL" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("CARTA MAYOR", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest18()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 3, Palo = "TREBOL" };
            var c2 = new Carta { Numero = 5, Palo = "TREBOL" };
            var c3 = new Carta { Numero = 7, Palo = "COCO" };
            var c4 = new Carta { Numero = 9, Palo = "ESPADA" };
            var c5 = new Carta { Numero = 12, Palo = "TREBOL" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("CARTA MAYOR", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest19()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 5, Palo = "TREBOL" };
            var c2 = new Carta { Numero = 5, Palo = "CORAZON" };
            var c3 = new Carta { Numero = 9, Palo = "COCO" };
            var c4 = new Carta { Numero = 10, Palo = "CORAZON" };
            var c5 = new Carta { Numero = 13, Palo = "TREBOL" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("DOBLE", cards.GetJugada(card));
        }
        [Test]
        public void pokeTest20()
        {
            List<Carta> card = new List<Carta>();
            var c1 = new Carta { Numero = 13, Palo = "CORAZON" };
            var c2 = new Carta { Numero = 8, Palo = "TREBOL" };
            var c3 = new Carta { Numero = 10, Palo = "COCO" };
            var c4 = new Carta { Numero = 9, Palo = "ESPADA" };
            var c5 = new Carta { Numero = 2, Palo = "CORAZON" };
            card.Add(c1);
            card.Add(c2);
            card.Add(c3);
            card.Add(c4);
            card.Add(c5);
            var cards = new PokerService();
            Assert.AreEqual("CARTA MAYOR", cards.GetJugada(card));
        }
    }
}
